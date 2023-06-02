// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityServer4;

namespace UserStorage
{
    public static class Config
    {
       public static IEnumerable<IdentityResource> IdentityResources =>
          new IdentityResource[]
          {
             new IdentityResources.OpenId(),
             //Profile is for given_name, family_name
             new IdentityResources.Profile(),
             new IdentityResources.Email(),
             new IdentityResource(
                "roles",
                "Your role(s)",
                new List<string>{ "role" }
             ),
             new IdentityResource(
                "city", 
                "Your city", 
                new List<string>{"city"}), 
          };

       public static IEnumerable<ApiScope> ApiScopes =>
          new ApiScope[]
          {
             new ApiScope("beersapi",
                "The Beers API",
                new List<string>{ "role", IdentityServerConstants.StandardScopes.Email })
          };

       public static IEnumerable<Client> Clients =>
          new Client[]
          {
             new Client
             {
                ClientId = "beersapiblazorclient",
                ClientName = "Beers API Blazor Client",
                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = true,
                RequireClientSecret = false,
                //ClientSecrets = { new Secret("secret".Sha256())},
                AllowedCorsOrigins =  { "https://localhost:5001", "https://localhost:44346" },
                AllowedScopes =
                {
                   IdentityServerConstants.StandardScopes.OpenId,
                   IdentityServerConstants.StandardScopes.Profile,
                   IdentityServerConstants.StandardScopes.Email,
                   "beersapi",
                   "roles",
                   "city"
                },
                RedirectUris = { "https://localhost:5001/authentication/login-callback" },
                PostLogoutRedirectUris = { "https://localhost:5001/" },
                AllowOfflineAccess = true,
                Enabled = true,
                RequireConsent = true
             }
          };
    }
}