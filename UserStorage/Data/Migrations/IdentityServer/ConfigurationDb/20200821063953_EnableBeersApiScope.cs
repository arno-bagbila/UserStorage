using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class EnableBeersApiScope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Emphasize" },
                values: new object[] { "Your access to the Beers API", true });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 543, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 548, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 548, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 542, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 543, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 543, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 543, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 543, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 542, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 542, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 542, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 21, 6, 39, 52, 542, DateTimeKind.Utc).AddTicks(2937));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Emphasize" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 611, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 613, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 613, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 610, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 611, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 611, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 611, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 611, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 610, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 610, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 610, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 58, 41, 610, DateTimeKind.Utc).AddTicks(6700));
        }
    }
}
