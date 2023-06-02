using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class AddingAdminToTewende : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 24, "role", "admin", "3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef7a2391-3b26-4cba-9a44-31d7f8698c70", "AQAAAAEAACcQAAAAEO+LuRIVxAJL4+d+YJH3sT35LPdOlMAXHA8Y0lNSkf6eiI5IeOy7dDzbR9tI5nkkhQ==", "7244a735-ecda-4ec8-8867-cee2aba0f137" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8da23f45-f65a-4961-aa80-6a40d3a49d07", "AQAAAAEAACcQAAAAEIvTy5KF3jc8jFc+lHZKoeivRWPWL5lKbu/RhGrtvV7gp16PZSOMOCGaEY+JknNnew==", "997acbc3-9530-42be-ad92-d0cae4441658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f72c88-8d6d-4830-8eaf-40a2f1ba7861", "AQAAAAEAACcQAAAAEL6Ovk/S2N6J2fi/Y0TUCkog5bqg7pdJN762aB40lN4flPUPh83iTRDUH4MidE/V8Q==", "a64f9446-1c16-4ef3-b205-6840f73f4c42" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 24);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dafaeb9b-0718-4d4c-a122-162f6bec7139", "AQAAAAEAACcQAAAAEOC/5wOgBYkBv0LBltYK+TgPs6mPAumn5LNzF+KEBlh+mXQidsSuenCuvrF1O7tGXg==", "475e665f-0dcb-4c36-bad9-16aee779d70f" });
        }
    }
}
