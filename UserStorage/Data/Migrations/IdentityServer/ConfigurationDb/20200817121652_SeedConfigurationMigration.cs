using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class SeedConfigurationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApiScopes",
                columns: new[] { "Id", "Description", "DisplayName", "Emphasize", "Enabled", "Name", "Required", "ShowInDiscoveryDocument" },
                values: new object[,]
                {
                    { 1, null, "web_api", false, true, "web_api", false, true },
                    { 2, null, "The Beers API", false, true, "beersapi", false, true }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AbsoluteRefreshTokenLifetime", "AccessTokenLifetime", "AccessTokenType", "AllowAccessTokensViaBrowser", "AllowOfflineAccess", "AllowPlainTextPkce", "AllowRememberConsent", "AllowedIdentityTokenSigningAlgorithms", "AlwaysIncludeUserClaimsInIdToken", "AlwaysSendClientClaims", "AuthorizationCodeLifetime", "BackChannelLogoutSessionRequired", "BackChannelLogoutUri", "ClientClaimsPrefix", "ClientId", "ClientName", "ClientUri", "ConsentLifetime", "Created", "Description", "DeviceCodeLifetime", "EnableLocalLogin", "Enabled", "FrontChannelLogoutSessionRequired", "FrontChannelLogoutUri", "IdentityTokenLifetime", "IncludeJwtId", "LastAccessed", "LogoUri", "NonEditable", "PairWiseSubjectSalt", "ProtocolType", "RefreshTokenExpiration", "RefreshTokenUsage", "RequireClientSecret", "RequireConsent", "RequirePkce", "RequireRequestObject", "SlidingRefreshTokenLifetime", "UpdateAccessTokenClaimsOnRefresh", "Updated", "UserCodeType", "UserSsoLifetime" },
                values: new object[,]
                {
                    { 1, 2592000, 3600, 0, false, false, false, true, null, false, false, 300, true, null, "client_", "client", null, null, null, new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(206), null, 300, true, true, true, null, 300, false, null, null, false, null, "oidc", 1, 1, true, true, false, false, 1296000, false, null, null, null },
                    { 2, 2592000, 3600, 0, false, false, false, true, null, false, false, 300, true, null, "client_", "ro.client", null, null, null, new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3502), null, 300, true, true, true, null, 300, false, null, null, false, null, "oidc", 1, 1, true, true, false, false, 1296000, false, null, null, null },
                    { 3, 2592000, 3600, 0, false, true, false, true, null, false, false, 300, true, null, "client_", "mvc", "MVC Client", null, null, new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3511), null, 300, true, true, true, null, 300, false, null, null, false, null, "oidc", 1, 1, true, true, false, false, 1296000, false, null, null, null },
                    { 4, 2592000, 3600, 0, false, false, false, true, null, false, false, 300, true, null, "client_", "js", "JavaScript client", null, null, new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3513), null, 300, true, true, true, null, 300, false, null, null, false, null, "oidc", 1, 1, false, true, true, false, 1296000, false, null, null, null },
                    { 5, 2592000, 3600, 0, false, true, false, false, null, false, false, 300, true, null, "client_", "beersapiblazorclient", "Beers API Blazor Client", null, null, new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3515), null, 300, true, true, true, null, 300, false, null, null, false, null, "oidc", 1, 1, false, true, true, false, 1296000, false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityResources",
                columns: new[] { "Id", "Created", "Description", "DisplayName", "Emphasize", "Enabled", "Name", "NonEditable", "Required", "ShowInDiscoveryDocument", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 17, 12, 16, 51, 671, DateTimeKind.Utc).AddTicks(7303), null, "Your user identifier", false, true, "openid", false, true, true, null },
                    { 2, new DateTime(2020, 8, 17, 12, 16, 51, 671, DateTimeKind.Utc).AddTicks(8071), "Your user profile information (first name, last name, etc.)", "User profile", true, true, "profile", false, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "ClientCorsOrigins",
                columns: new[] { "Id", "ClientId", "Origin" },
                values: new object[,]
                {
                    { 1, 4, "http://localhost:5003" },
                    { 3, 5, "https://localhost:44346" },
                    { 2, 5, "https://localhost:5001" }
                });

            migrationBuilder.InsertData(
                table: "ClientGrantTypes",
                columns: new[] { "Id", "ClientId", "GrantType" },
                values: new object[,]
                {
                    { 1, 1, "client_credentials" },
                    { 2, 2, "password" },
                    { 4, 4, "authorization_code" },
                    { 3, 3, "hybrid" },
                    { 5, 5, "authorization_code" }
                });

            migrationBuilder.InsertData(
                table: "ClientPostLogoutRedirectUris",
                columns: new[] { "Id", "ClientId", "PostLogoutRedirectUri" },
                values: new object[,]
                {
                    { 2, 4, "http://localhost:5003/index.html" },
                    { 1, 3, "http://localhost:5002/signout-callback-oidc" },
                    { 3, 5, "https://localhost:5001/" }
                });

            migrationBuilder.InsertData(
                table: "ClientRedirectUris",
                columns: new[] { "Id", "ClientId", "RedirectUri" },
                values: new object[,]
                {
                    { 2, 4, "http://localhost:5003/callback.html" },
                    { 3, 5, "https://localhost:5001/authentication/login-callback" },
                    { 1, 3, "http://localhost:5002/signin-oidc" }
                });

            migrationBuilder.InsertData(
                table: "ClientScopes",
                columns: new[] { "Id", "ClientId", "Scope" },
                values: new object[,]
                {
                    { 9, 5, "openid" },
                    { 10, 5, "profile" },
                    { 11, 5, "email" },
                    { 12, 5, "beersapi" },
                    { 8, 4, "web_api" },
                    { 2, 4, "profile" },
                    { 7, 3, "web_api" },
                    { 3, 3, "openid" },
                    { 1, 3, "profile" },
                    { 6, 2, "web_api" },
                    { 5, 1, "web_api" },
                    { 4, 4, "openid" }
                });

            migrationBuilder.InsertData(
                table: "ClientSecrets",
                columns: new[] { "Id", "ClientId", "Created", "Description", "Expiration", "Type", "Value" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2020, 8, 17, 12, 16, 51, 675, DateTimeKind.Utc).AddTicks(1570), null, null, "SharedSecret", "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=" },
                    { 2, 2, new DateTime(2020, 8, 17, 12, 16, 51, 675, DateTimeKind.Utc).AddTicks(1256), null, null, "SharedSecret", "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=" },
                    { 1, 1, new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(7608), null, null, "SharedSecret", "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=" }
                });

            migrationBuilder.InsertData(
                table: "IdentityResourceClaims",
                columns: new[] { "Id", "IdentityResourceId", "Type" },
                values: new object[,]
                {
                    { 5, 2, "family_name" },
                    { 1, 1, "sub" },
                    { 2, 2, "email" },
                    { 3, 2, "website" },
                    { 4, 2, "given_name" },
                    { 6, 2, "name" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
