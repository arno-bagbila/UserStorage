using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddApiScopeClaimsRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApiScopeClaims",
                columns: new[] { "Id", "ScopeId", "Type" },
                values: new object[] { 1, 2, "role" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiScopeClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 144, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 144, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 141, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(309));
        }
    }
}
