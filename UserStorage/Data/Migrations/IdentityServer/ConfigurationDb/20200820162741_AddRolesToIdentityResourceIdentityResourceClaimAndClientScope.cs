using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserStorage.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddRolesToIdentityResourceIdentityResourceClaimAndClientScope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClientScopes",
                columns: new[] { "Id", "ClientId", "Scope" },
                values: new object[] { 14, 5, "roles" });

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

            migrationBuilder.InsertData(
                table: "IdentityResources",
                columns: new[] { "Id", "Created", "Description", "DisplayName", "Emphasize", "Enabled", "Name", "NonEditable", "Required", "ShowInDiscoveryDocument", "Updated" },
                values: new object[] { 4, new DateTime(2020, 8, 20, 16, 27, 41, 142, DateTimeKind.Utc).AddTicks(309), "Your user privileges (admin, etc.)", "Your role(s)", true, true, "roles", false, false, true, null });

            migrationBuilder.InsertData(
                table: "IdentityResourceClaims",
                columns: new[] { "Id", "IdentityResourceId", "Type" },
                values: new object[] { 8, 4, "role" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IdentityResourceClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
