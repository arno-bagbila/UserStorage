using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddEmailToApiScopeClaimsRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApiScopeClaims",
                columns: new[] { "Id", "ScopeId", "Type" },
                values: new object[] { 2, 2, "email" });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 565, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 573, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 573, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 564, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 564, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 564, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 564, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 564, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 562, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 563, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 563, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 1, 28, 20, 32, 3, 563, DateTimeKind.Utc).AddTicks(2075));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiScopeClaims",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
