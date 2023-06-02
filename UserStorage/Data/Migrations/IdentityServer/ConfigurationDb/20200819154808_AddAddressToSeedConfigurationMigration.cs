using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddAddressToSeedConfigurationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClientScopes",
                columns: new[] { "Id", "ClientId", "Scope" },
                values: new object[] { 13, 5, "address" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 675, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 675, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 672, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 671, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 17, 12, 16, 51, 671, DateTimeKind.Utc).AddTicks(8071));
        }
    }
}
