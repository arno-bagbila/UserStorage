using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddAddressToIdentityResourceClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 767, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 769, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 769, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 767, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 767, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 767, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 767, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 767, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.InsertData(
                table: "IdentityResourceClaims",
                columns: new[] { "Id", "IdentityResourceId", "Type" },
                values: new object[] { 7, 3, "address" });

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 766, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 766, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 40, 57, 766, DateTimeKind.Utc).AddTicks(8949));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 36, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 38, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 38, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 35, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 36, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 36, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 36, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 36, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 35, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 35, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 12, 29, 19, 35, DateTimeKind.Utc).AddTicks(7945));
        }
    }
}
