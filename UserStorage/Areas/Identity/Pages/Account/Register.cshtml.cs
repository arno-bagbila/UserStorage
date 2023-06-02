using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using NServiceBus;
using UserStorage.Areas.Identity.Pages.Account.CustomValidation;
using UserStorage.Integration.Messages.Commands;
using UserStorage.Models;

namespace UserStorage.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Family Name")]
            public string FamilyName { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            public string Country { get; set; }

            [Required]
            [DisplayName("Date of Birth")]
            [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [MinimumAge(18)]
            public DateTime DateOfBirth { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("https://localhost:5001/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, EmailConfirmed = true};
                var result = await _userManager.CreateAsync(user, Input.Password);
                
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _userManager.AddClaimsAsync(user, new Claim[]
                    {
                       new Claim(JwtClaimTypes.FamilyName, Input.FamilyName),
                       new Claim(JwtClaimTypes.GivenName, Input.FirstName),
                       new Claim("city", Input.City),
                       new Claim("country", Input.Country),
                       new Claim(JwtClaimTypes.BirthDate, Input.DateOfBirth.ToShortDateString())
                    });

                    //call BeersApi from here
                    var createUser = new CreateUser
                    {
                       Email = Input.Email,
                       UId = Guid.Parse(user.Id),
                       RoleName = "BeersApiReadOnly",
                       FirstName = Input.FirstName
                    };

                    await SendCreateUserCommand(createUser).ConfigureAwait(false);

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Redirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private async Task SendCreateUserCommand(CreateUser createUser)
        {
           var endpointConfiguration = new EndpointConfiguration("UserRegistration");
           var transport = endpointConfiguration.UseTransport<LearningTransport>();
           var routing = transport.Routing();
           routing.RouteToEndpoint(typeof(CreateUser), "BeersApiUpdater");

           var endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);

           await endpointInstance.Send(createUser).ConfigureAwait(false);
           
           await endpointInstance.Stop().ConfigureAwait(false);
        }
    }
}
