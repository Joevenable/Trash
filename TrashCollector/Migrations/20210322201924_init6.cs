using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01077d23-9648-432e-9934-00771fc1d954");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5ff2d-f3b2-4ecb-bd7f-a67fe858f36f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f702bec-930f-49f0-9f0d-2f1a91e25f53", "ce0b84ab-57e4-4a27-b35f-dd985d7a7d37", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e74a20b2-5acd-4489-a132-58268ced7269", "719e3b0c-251a-4757-bade-e101be4e5eac", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f702bec-930f-49f0-9f0d-2f1a91e25f53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e74a20b2-5acd-4489-a132-58268ced7269");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01077d23-9648-432e-9934-00771fc1d954", "19816cbb-74ec-48b8-8975-54199cc053f9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6b5ff2d-f3b2-4ecb-bd7f-a67fe858f36f", "7d75d59e-3d86-4db8-b1df-7713ba3f393d", "Customer", "CUSTOMER" });
        }
    }
}
