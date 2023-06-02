using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserStorage.Models;

namespace UserStorage.Data
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //Seed data
            UsersSeed(builder);
        }

      private void UsersSeed(ModelBuilder builder)
      {
         var password = "My long 123$ password";

         var alice = new ApplicationUser
         {
            Id = "1",
            UserName = "alice",
            NormalizedUserName = "ALICE",
            Email = "AliceSmith@email.com",
            NormalizedEmail = "AliceSmith@email.com".ToUpper(),
            EmailConfirmed = true
         };
         alice.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(alice, password);

         var bob = new ApplicationUser
         {
            Id = "2",
            UserName = "bob",
            NormalizedUserName = "BOB",
            Email = "BobSmith@email.com",
            NormalizedEmail = "bobsmith@email.com".ToUpper(),
            EmailConfirmed = true,
         };
         bob.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(bob, password);

         var tewende = new ApplicationUser
         {
            Id = "3",
            UserName = "tewende",
            NormalizedUserName = "TEWENDE",
            Email = "tewende@test.com",
            NormalizedEmail = "tewende@test.com".ToUpper(),
            EmailConfirmed = true
         };
         tewende.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(tewende, password);

         builder.Entity<ApplicationUser>()
             .HasData(alice, bob, tewende);


         builder.Entity<IdentityUserClaim<string>>()
             .HasData(
                 new IdentityUserClaim<string>
                 {
                    Id = 1,
                    UserId = "1",
                    ClaimType = "name",
                    ClaimValue = "Alice Smith"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 2,
                    UserId = "1",
                    ClaimType = "given_name",
                    ClaimValue = "Alice"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 3,
                    UserId = "1",
                    ClaimType = "family_name",
                    ClaimValue = "Smith"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 4,
                    UserId = "1",
                    ClaimType = "email",
                    ClaimValue = "AliceSmith@email.com"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 5,
                    UserId = "1",
                    ClaimType = "website",
                    ClaimValue = "http://alice.com"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 6,
                    UserId = "2",
                    ClaimType = "name",
                    ClaimValue = "Bob Smith"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 7,
                    UserId = "2",
                    ClaimType = "given_name",
                    ClaimValue = "Bob"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 8,
                    UserId = "2",
                    ClaimType = "family_name",
                    ClaimValue = "Smith"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 9,
                    UserId = "2",
                    ClaimType = "email",
                    ClaimValue = "BobSmith@email.com"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 10,
                    UserId = "2",
                    ClaimType = "website",
                    ClaimValue = "http://bob.com"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 11,
                    UserId = "1",
                    ClaimType = "email_verified",
                    ClaimValue = true.ToString()
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 12,
                    UserId = "2",
                    ClaimType = "email_verified",
                    ClaimValue = true.ToString()
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 13,
                    UserId = "1",
                    ClaimType = "address",
                    ClaimValue = @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 14,
                    UserId = "2",
                    ClaimType = "address",
                    ClaimValue = @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 15,
                    UserId = "1",
                    ClaimType = "location",
                    ClaimValue = "somewhere"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 16,
                    UserId = "3",
                    ClaimType = "name",
                    ClaimValue = "Tewende Bagbila"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 17,
                    UserId = "3",
                    ClaimType = "given_name",
                    ClaimValue = "Tewende"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 18,
                    UserId = "3",
                    ClaimType = "family_name",
                    ClaimValue = "Bagbila"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 19,
                    UserId = "3",
                    ClaimType = "email",
                    ClaimValue = "tewende@test.com"
                 },
                 new IdentityUserClaim<string>
                 {
                    Id = 20,
                    UserId = "3",
                    ClaimType = "website",
                    ClaimValue = "http://tewende.com"
                 }, 
                 new IdentityUserClaim<string>
                 {
                    Id = 21,
                    UserId = "3",
                    ClaimType = "email_verified",
                    ClaimValue = true.ToString()
                 }, 
                 new IdentityUserClaim<string>
                 {
                    Id = 22,
                    UserId = "3",
                    ClaimType = "address",
                    ClaimValue = @"{ 'street_address': 'One Hacker Way', 'locality': 'London', 'postal_code': SW17 9JY, 'country': 'United Kingdom' }"
                 }, 
                 new IdentityUserClaim<string>
                 {
                    Id = 23,
                    UserId = "3",
                    ClaimType = "location",
                    ClaimValue = "anywhere"
                 }, 
                 new IdentityUserClaim<string>
                 {
                    Id = 24,
                    UserId = "3",
                    ClaimType = JwtClaimTypes.Role,
                    ClaimValue = "admin"
                 });
      }
    }
}
