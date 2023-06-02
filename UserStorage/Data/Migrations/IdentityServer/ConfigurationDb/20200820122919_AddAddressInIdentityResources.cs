using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddAddressInIdentityResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "IdentityResources",
                columns: new[] { "Id", "Created", "Description", "DisplayName", "Emphasize", "Enabled", "Name", "NonEditable", "Required", "ShowInDiscoveryDocument", "Updated" },
                values: new object[] { 3, new DateTime(2020, 8, 20, 12, 29, 19, 35, DateTimeKind.Utc).AddTicks(7945), "Your user address", "User address", true, true, "address", false, false, true, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 633, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 641, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 641, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 631, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 632, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 632, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 632, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 632, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 630, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 19, 15, 48, 7, 630, DateTimeKind.Utc).AddTicks(8140));
        }
    }
}
