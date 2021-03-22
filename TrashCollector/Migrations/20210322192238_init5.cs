using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03c62728-bffb-421d-8f9c-9144351f8308");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a6ddc40-2be6-48c5-9040-16e2a41f9695");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01077d23-9648-432e-9934-00771fc1d954", "19816cbb-74ec-48b8-8975-54199cc053f9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6b5ff2d-f3b2-4ecb-bd7f-a67fe858f36f", "7d75d59e-3d86-4db8-b1df-7713ba3f393d", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01077d23-9648-432e-9934-00771fc1d954");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5ff2d-f3b2-4ecb-bd7f-a67fe858f36f");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03c62728-bffb-421d-8f9c-9144351f8308", "6bfdee5a-0c15-43aa-bf0a-3d51f2738825", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a6ddc40-2be6-48c5-9040-16e2a41f9695", "0de5c4f5-314e-4538-bd56-7360163b1fb0", "Customer", "CUSTOMER" });
        }
    }
}
