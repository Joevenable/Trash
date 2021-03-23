using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f702bec-930f-49f0-9f0d-2f1a91e25f53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e74a20b2-5acd-4489-a132-58268ced7269");

            migrationBuilder.AlterColumn<bool>(
                name: "Pickups",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a347919c-9d8e-4a0f-9581-676dd77da435", "d22efc55-3bd3-4772-aa96-66d029d27bd0", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3777dfe-ecc5-4665-84ba-26ea52f9b1b5", "7ab3a130-1918-496c-972d-469349658856", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a347919c-9d8e-4a0f-9581-676dd77da435");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3777dfe-ecc5-4665-84ba-26ea52f9b1b5");

            migrationBuilder.AlterColumn<string>(
                name: "Pickups",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f702bec-930f-49f0-9f0d-2f1a91e25f53", "ce0b84ab-57e4-4a27-b35f-dd985d7a7d37", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e74a20b2-5acd-4489-a132-58268ced7269", "719e3b0c-251a-4757-bade-e101be4e5eac", "Customer", "CUSTOMER" });
        }
    }
}
