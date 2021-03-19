using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b1afa03-f36c-46a7-a8b5-bb33d3292764");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51b4aba8-9d9f-4732-843d-94421c10035c", "f6d1d20f-13b9-40ed-bc26-27f6e9f7d2b9", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2212ab5-5689-4d3f-ac87-e1da7cb9ef82", "2b864477-82ea-4d51-9387-d641f49a7b3c", "Customer", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51b4aba8-9d9f-4732-843d-94421c10035c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2212ab5-5689-4d3f-ac87-e1da7cb9ef82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b1afa03-f36c-46a7-a8b5-bb33d3292764", "11ab2f6d-9471-4460-8d6a-5d49f9672934", "Admin", "ADMIN" });
        }
    }
}
