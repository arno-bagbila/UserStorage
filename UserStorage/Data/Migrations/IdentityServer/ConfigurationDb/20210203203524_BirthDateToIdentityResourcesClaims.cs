using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class BirthDateToIdentityResourcesClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 791, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 796, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 796, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 791, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 791, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 791, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 791, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 791, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.InsertData(
                table: "IdentityResourceClaims",
                columns: new[] { "Id", "IdentityResourceId", "Type" },
                values: new object[] { 11, 2, "birthdate" });

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 790, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 790, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 790, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 2, 3, 20, 35, 22, 790, DateTimeKind.Utc).AddTicks(8204));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 875, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 881, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 881, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 875, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 875, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 875, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 875, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 875, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 874, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 874, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 874, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 2, 2, 11, 32, 23, 874, DateTimeKind.Utc).AddTicks(8556));
        }
    }
}
