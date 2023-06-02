//// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
//// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


//using IdentityModel;
//using IdentityServer4.Test;
//using System.Collections.Generic;
//using System.Security.Claims;
//using System.Text.Json;
//using IdentityServer4;

//namespace IdentityServerHost.Quickstart.UI
//{
//    public class TestUsers
//    {
//       public static List<TestUser> Users
//       {
//          get
//          {
//             var address = new
//             {
//                street_address = "One Hacker Way",
//                locality = "Heidelberg",
//                postal_code = 69118,
//                country = "Germany"
//             };

//             return new List<TestUser>
//             {
//                new TestUser
//                {
//                   SubjectId = "48D7B85A-FD66-4017-807B-A4A94701F0D9",
//                   Username = "tewende@test.com",
//                   Password = "password",

//                   Claims = new List<Claim>
//                   {
//                      new Claim("given_name", "Arnaud"),
//                      new Claim("family_name", "Bagbila"),
//                      new Claim(JwtClaimTypes.Email, "tewende@test.com"),
//                      new Claim("role", "Admin")

//                   }
//                },
//                new TestUser
//                {
//                   SubjectId = "A0BB7EBE-557B-4074-BAB4-6F9690E9E151",
//                   Username = "rom@test.com",
//                   Password = "password",

//                   Claims = new List<Claim>
//                   {
//                      new Claim("given_name", "Stephanie"),
//                      new Claim("family_name", "Romagne"),
//                      new Claim(JwtClaimTypes.Email, "roma@test.com"),
//                      new Claim("role", "User")
//                   }
//                }
//             };
//          }
//       }
//    }
//}