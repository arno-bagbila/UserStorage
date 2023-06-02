using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class AddingTewendeToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "669a46a4-315e-462c-b0ac-4f552292526b", "AQAAAAEAACcQAAAAEDz+/g9LITZXileI42bq7+tLHRR9WDc1EU3TqlAps366xwIIqVgkVxE3NSIV0XCOIQ==", "aca391d8-ef0b-4b14-8d42-e92576ad0b13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "827fe977-005e-4b62-824b-8fd68cdd63d6", "AQAAAAEAACcQAAAAEO53gyFhbucyeUB14BURFNcFNm0uS6k1GQ+MSlv1Vj4gzBq2AMBhi+hug9bHQYvkTA==", "73a66b0c-0bd9-402d-9d8a-99c96d578b0c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3", 0, "dafaeb9b-0718-4d4c-a122-162f6bec7139", "tewende@test.com", true, false, null, "TEWENDE@TEST.COM", "TEWENDE", "AQAAAAEAACcQAAAAEOC/5wOgBYkBv0LBltYK+TgPs6mPAumn5LNzF+KEBlh+mXQidsSuenCuvrF1O7tGXg==", null, false, "475e665f-0dcb-4c36-bad9-16aee779d70f", false, "tewende" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 16, "name", "Tewende Bagbila", "3" },
                    { 17, "given_name", "Tewende", "3" },
                    { 18, "family_name", "Bagbila", "3" },
                    { 19, "email", "tewende@test.com", "3" },
                    { 20, "website", "http://tewende.com", "3" },
                    { 21, "email_verified", "True", "3" },
                    { 22, "address", "{ 'street_address': 'One Hacker Way', 'locality': 'London', 'postal_code': SW17 9JY, 'country': 'United Kingdom' }", "3" },
                    { 23, "location", "anywhere", "3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c1d7d0d-3bb6-4056-8813-34d903fcdc7a", "AQAAAAEAACcQAAAAENYl+gW6zfbpoPtoJXSpJ4xoemFroEFvKs1yRSZ5wh3i14b8+L/ZTNxKlAE+J8iG4Q==", "60c6e1b4-ed30-4d1f-97c6-2d55faae7c4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11a97ed7-3cec-43b4-bc4d-89b362f0df23", "AQAAAAEAACcQAAAAEHYF3vtohJT5dXYaswQK2hDXTx4ihB8fjPXK5Ig3g4jqWNCMWW/VbLtgJlFqfVgdPw==", "166e28a9-9407-46c7-b73d-ab6bc3a667ba" });
        }
    }
}
