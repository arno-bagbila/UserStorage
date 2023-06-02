using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddCityAndCountryToIdentityResourcesClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "IdentityResourceClaims",
                columns: new[] { "Id", "IdentityResourceId", "Type" },
                values: new object[,]
                {
                    { 9, 2, "city" },
                    { 10, 2, "country" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 10);

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
    }
}
