using System;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Extensions;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;

namespace UserStorage.Data
{
   public class ConfigurationDbContext : IdentityServer4.EntityFramework.DbContexts.ConfigurationDbContext<ConfigurationDbContext>
   {
      private readonly ConfigurationStoreOptions _storeOptions;

      public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions) : base(options, storeOptions)
      {
         _storeOptions = storeOptions;
      }


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ConfigureClientContext(_storeOptions);
         modelBuilder.ConfigureResourcesContext(_storeOptions);

         base.OnModelCreating(modelBuilder);
         ClientSeed(modelBuilder);
      }

      private void ClientSeed(ModelBuilder builder)
      {

         builder.Entity<ApiScope>()
             .HasData(
                new ApiScope
                {
                   Id = 1,
                   Name = "web_api",
                   DisplayName = "web_api",
                   Description = null,
                   Required = false,
                   Emphasize = false,
                   ShowInDiscoveryDocument = true
                },
                 new ApiScope
                 {
                    Id = 2,
                    Name = "beersapi",
                    DisplayName = "The Beers API",
                    Enabled = true,
                    Description = "Your access to the Beers API",
                    Required = false,
                    Emphasize = true,
                    ShowInDiscoveryDocument = true
                 }
             );

         builder.Entity<IdentityResource>().HasData
             (
                 new IdentityResource()
                 {
                    Id = 1,
                    Enabled = true,
                    Name = "openid",
                    DisplayName = "Your user identifier",
                    Description = null,
                    Required = true,
                    Emphasize = false,
                    ShowInDiscoveryDocument = true,
                    Created = DateTime.UtcNow,
                    Updated = null,
                    NonEditable = false
                 },
                 new IdentityResource()
                 {
                    Id = 2,
                    Enabled = true,
                    Name = "profile",
                    DisplayName = "User profile",
                    Description = "Your user profile information (first name, last name, etc.)",
                    Required = false,
                    Emphasize = true,
                    ShowInDiscoveryDocument = true,
                    Created = DateTime.UtcNow,
                    Updated = null,
                    NonEditable = false,
                 }, 
                 new IdentityResource
                 {
                    Id = 3,
                    Enabled = true,
                    Name = "address",
                    DisplayName = "User address",
                    Description = "Your user address",
                    Required = false,
                    Emphasize = true,
                    ShowInDiscoveryDocument = true,
                    Created = DateTime.UtcNow,
                    Updated = null,
                    NonEditable = false
                 }, 
                 new IdentityResource
                 {
                    Id = 4,
                    Enabled = true,
                    Name = "roles",
                    DisplayName = "Your role(s)",
                    Description = "Your user privileges (admin, etc.)",
                    Required = false,
                    Emphasize = true,
                    ShowInDiscoveryDocument = true,
                    Created = DateTime.UtcNow,
                    Updated = null,
                    NonEditable = false
                 });

         builder.Entity<IdentityResourceClaim>()
             .HasData(
                 new IdentityResourceClaim
                 {
                    Id = 1,
                    IdentityResourceId = 1,
                    Type = "sub"
                 },
                 new IdentityResourceClaim
                 {
                    Id = 2,
                    IdentityResourceId = 2,
                    Type = JwtClaimTypes.Email
                 },
                 new IdentityResourceClaim
                 {
                    Id = 3,
                    IdentityResourceId = 2,
                    Type = JwtClaimTypes.WebSite
                 },
                 new IdentityResourceClaim
                 {
                    Id = 4,
                    IdentityResourceId = 2,
                    Type = JwtClaimTypes.GivenName
                 },
                 new IdentityResourceClaim
                 {
                    Id = 5,
                    IdentityResourceId = 2,
                    Type = JwtClaimTypes.FamilyName
                 },
                 new IdentityResourceClaim
                 {
                    Id = 6,
                    IdentityResourceId = 2,
                    Type = JwtClaimTypes.Name
                 }, 
                 new IdentityResourceClaim
                 {
                    Id = 7,
                    IdentityResourceId = 3,
                    Type = JwtClaimTypes.Address
                 }, 
                 new IdentityResourceClaim
                 {
                    Id = 8,
                    IdentityResourceId = 4,
                    Type = JwtClaimTypes.Role
                 }, new IdentityResourceClaim
                 {
                    Id = 9,
                    IdentityResourceId = 2,
                    Type = "city"
                 }, new IdentityResourceClaim
                 {
                    Id = 10,
                    IdentityResourceId = 2,
                    Type = "country"
                 }, new IdentityResourceClaim
                 {
                    Id = 11,
                    IdentityResourceId = 2,
                    Type = JwtClaimTypes.BirthDate
                 });
         builder.Entity<ApiScopeClaim>()
            .HasData(
               new ApiScopeClaim
                  {
                     Id = 1,
                     ScopeId = 2,
                     Type = JwtClaimTypes.Role
                  },
               new ApiScopeClaim
               {
                  Id = 2,
                  ScopeId = 2,
                  Type = JwtClaimTypes.Email
               });

         builder.Entity<Client>()
             .HasData(
                 new Client
                 {
                    Id = 1,
                    Enabled = true,
                    ClientId = "client",
                    ProtocolType = "oidc",
                    RequireClientSecret = true,
                    RequireConsent = true,
                    ClientName = null,
                    Description = null,
                    AllowRememberConsent = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = false,
                    AllowAccessTokensViaBrowser = false,
                    AllowOfflineAccess = false
                 },
                 new Client
                 {
                    Id = 2,
                    Enabled = true,
                    ClientId = "ro.client",
                    ProtocolType = "oidc",
                    RequireClientSecret = true,
                    RequireConsent = true,
                    ClientName = null,
                    Description = null,
                    AllowRememberConsent = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = false,
                    AllowAccessTokensViaBrowser = false,
                    AllowOfflineAccess = false
                 },
                 new Client
                 {
                    Id = 3,
                    Enabled = true,
                    ClientId = "mvc",
                    ProtocolType = "oidc",
                    RequireClientSecret = true,
                    RequireConsent = true,
                    ClientName = "MVC Client",
                    Description = null,
                    AllowRememberConsent = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = false,
                    AllowAccessTokensViaBrowser = false,
                    AllowOfflineAccess = true
                 },
                 new Client
                 {
                    Id = 4,
                    Enabled = true,
                    ClientId = "js",
                    ProtocolType = "oidc",
                    RequireClientSecret = false,
                    RequireConsent = true,
                    ClientName = "JavaScript client",
                    Description = null,
                    AllowRememberConsent = true,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    AllowAccessTokensViaBrowser = false,
                    AllowOfflineAccess = false
                 }, new Client
                 {
                    Id = 5,
                    ClientId = "beersapiblazorclient",
                    Enabled = true,
                    ProtocolType = "oidc",
                    RequireClientSecret = false,
                    RequireConsent = true,
                    ClientName = "Beers API Blazor Client",
                    Description = null,
                    AllowRememberConsent = false,
                    AlwaysIncludeUserClaimsInIdToken = false,
                    RequirePkce = true,
                    AllowAccessTokensViaBrowser = false,
                    AllowOfflineAccess = true
                 });

         builder.Entity<ClientGrantType>()
             .HasData(
                 new ClientGrantType
                 {
                    Id = 1,
                    GrantType = "client_credentials",
                    ClientId = 1
                 },
                 new ClientGrantType
                 {
                    Id = 2,
                    GrantType = "password",
                    ClientId = 2
                 },
                 new ClientGrantType
                 {
                    Id = 3,
                    GrantType = "hybrid",
                    ClientId = 3
                 },
                 new ClientGrantType
                 {
                    Id = 4,
                    GrantType = "authorization_code",
                    ClientId = 4
                 }, 
                 new ClientGrantType
                 {
                    Id = 5,
                    GrantType = "authorization_code",
                    ClientId = 5
                 });

         builder.Entity<ClientScope>()
             .HasData(
                 new ClientScope
                 {
                    Id = 1,
                    Scope = "profile",
                    ClientId = 3
                 },
                 new ClientScope
                 {
                    Id = 2,
                    Scope = "profile",
                    ClientId = 4
                 },
                 new ClientScope
                 {
                    Id = 3,
                    Scope = "openid",
                    ClientId = 3
                 },
                 new ClientScope
                 {
                    Id = 4,
                    Scope = "openid",
                    ClientId = 4
                 },
                 new ClientScope
                 {
                    Id = 5,
                    Scope = "web_api",
                    ClientId = 1
                 }
                 ,
                 new ClientScope
                 {
                    Id = 6,
                    Scope = "web_api",
                    ClientId = 2
                 }
                 ,
                 new ClientScope
                 {
                    Id = 7,
                    Scope = "web_api",
                    ClientId = 3
                 }
                 ,
                 new ClientScope
                 {
                    Id = 8,
                    Scope = "web_api",
                    ClientId = 4
                 }, 
                 new ClientScope
                 {
                    Id = 9,
                    Scope = IdentityServerConstants.StandardScopes.OpenId,
                    ClientId = 5
                 },
                 new ClientScope
                 {
                    Id = 10,
                    Scope = IdentityServerConstants.StandardScopes.Profile,
                    ClientId = 5
                 }, new ClientScope
                 {
                    Id = 11,
                    Scope = IdentityServerConstants.StandardScopes.Email,
                    ClientId = 5
                 }, new ClientScope
                 {
                    Id = 12,
                    Scope = "beersapi",
                    ClientId = 5
                 }, 
                 new ClientScope
                 {
                    Id = 13,
                    Scope = IdentityServerConstants.StandardScopes.Address,
                    ClientId = 5
                 }, 
                 new ClientScope
                 {
                    Id = 14,
                    Scope = "roles",
                    ClientId = 5
                 });

         builder.Entity<ClientSecret>()
             .HasData(
                     new ClientSecret
                     {
                        Id = 1,
                        Value = "secret".ToSha256(),
                        Type = "SharedSecret",
                        ClientId = 1
                     },
                     new ClientSecret
                     {
                        Id = 2,
                        Value = "secret".ToSha256(),
                        Type = "SharedSecret",
                        ClientId = 2
                     },
                     new ClientSecret
                     {
                        Id = 3,
                        Value = "secret".ToSha256(),
                        Type = "SharedSecret",
                        ClientId = 3
                     });

         builder.Entity<ClientPostLogoutRedirectUri>()
             .HasData(
             new ClientPostLogoutRedirectUri
             {
                Id = 1,
                PostLogoutRedirectUri = "http://localhost:5002/signout-callback-oidc",
                ClientId = 3
             },
             new ClientPostLogoutRedirectUri
             {
                Id = 2,
                PostLogoutRedirectUri = "http://localhost:5003/index.html",
                ClientId = 4
             }, new ClientPostLogoutRedirectUri
             {
                Id = 3,
                PostLogoutRedirectUri = "https://localhost:5001/",
                ClientId = 5
             });

         builder.Entity<ClientRedirectUri>()
             .HasData(
             new ClientRedirectUri
             {
                Id = 1,
                RedirectUri = "http://localhost:5002/signin-oidc",
                ClientId = 3
             },
             new ClientRedirectUri
             {
                Id = 2,
                RedirectUri = "http://localhost:5003/callback.html",
                ClientId = 4
             }, new ClientRedirectUri
             {
                Id = 3,
                RedirectUri = "https://localhost:5001/authentication/login-callback",
                ClientId = 5
             });

         builder.Entity<ClientCorsOrigin>()
             .HasData(
             new ClientCorsOrigin
             {
                Id = 1,
                Origin = "http://localhost:5003",
                ClientId = 4
             }, new ClientCorsOrigin
             {
                Id = 2,
                Origin = "https://localhost:5001",
                ClientId = 5
             }, new ClientCorsOrigin
             {
                Id = 3,
                Origin = "https://localhost:44346",
                ClientId = 5
             });
      }
   }
}
