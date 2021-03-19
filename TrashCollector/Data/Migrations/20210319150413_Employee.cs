using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0c23eac7-7831-4956-85d6-3fcc15789a91", "63bcefd8-769b-4d91-b743-3df83991e168", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "481881f8-d15d-4957-b00c-62487f5444d8", "f72bdacc-b813-47b2-8883-fb0c8a6a65c9", "Customer", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c23eac7-7831-4956-85d6-3fcc15789a91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "481881f8-d15d-4957-b00c-62487f5444d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51b4aba8-9d9f-4732-843d-94421c10035c", "f6d1d20f-13b9-40ed-bc26-27f6e9f7d2b9", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2212ab5-5689-4d3f-ac87-e1da7cb9ef82", "2b864477-82ea-4d51-9387-d641f49a7b3c", "Customer", "Customer" });
        }
    }
}
