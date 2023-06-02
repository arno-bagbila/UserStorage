// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using System.Reflection;
using IdentityServer4.Configuration;
using IdentityServerHost.Quickstart.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserStorage.Data;
using UserStorage.Models;
using UserStorage.Services;

namespace UserStorage
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

      public Startup(IWebHostEnvironment environment, IConfiguration configuration)
        {
            Environment = environment;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // uncomment, if you want to add an MVC-based UI
            //Using addmvc to access the razor pages for the registration flow
            services.AddMvc();

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;

            services.AddDbContext<IdentityDbContext>(options =>
            {
               options.UseSqlServer(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly))
                  .EnableSensitiveDataLogging();
            });

            services.AddDbContext<ConfigurationDbContext>(options => options.UseSqlServer(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly)));

            //This code could have lived in IdentityHostingStartup in Areas/Identity
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
               {
                  options.SignIn.RequireConfirmedEmail = true;
               })
               .AddEntityFrameworkStores<IdentityDbContext>()
               .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, EmailSender>();

            var builder = services.AddIdentityServer(options =>
               {
                  options.Events.RaiseErrorEvents = true;
                  options.Events.RaiseInformationEvents = true;
                  options.Events.RaiseFailureEvents = true;
                  options.Events.RaiseSuccessEvents = true;
                  options.UserInteraction.LoginUrl = "/Account/Login";
                  options.UserInteraction.LogoutUrl = "/Account/Logout";
                  options.Authentication = new AuthenticationOptions()
                  {
                     CookieLifetime = TimeSpan.FromHours(10), // ID server cookie timeout set to 10 hours
                     CookieSlidingExpiration = true
                  };

               })
               .AddConfigurationStore(options =>
               {
                  options.ConfigureDbContext = b =>
                     b.UseSqlServer(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly));
               })
               .AddOperationalStore(options =>
               {
                  options.ConfigureDbContext = b =>
                     b.UseSqlServer(connectionString, sql => sql.MigrationsAssembly(migrationsAssembly));
                  options.EnableTokenCleanup = true;
               })
               .AddAspNetIdentity<ApplicationUser>();

               // not recommended for production - you need to store your key material somewhere secure
               builder.AddDeveloperSigningCredential();
        }

        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // uncomment if you want to add MVC
            app.UseStaticFiles();
            app.UseRouting();
            
            app.UseIdentityServer();

            // uncomment, if you want to add MVC
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            { 
               //MapRazorPages to access the razor pages where the user registration is
               endpoints.MapControllers();
               endpoints.MapDefaultControllerRoute();
               endpoints.MapRazorPages();

            });
        }
    }
}
