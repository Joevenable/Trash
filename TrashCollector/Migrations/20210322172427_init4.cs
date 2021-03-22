using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d98ed6fd-dfb7-4778-8301-206229ec18b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea183b3b-0e7d-4c98-9259-d4ca2565bbd3");

            migrationBuilder.AddColumn<string>(
                name: "Pickups",
                table: "Employees",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VacationHoldStart",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VacationHoldEnd",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03c62728-bffb-421d-8f9c-9144351f8308", "6bfdee5a-0c15-43aa-bf0a-3d51f2738825", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a6ddc40-2be6-48c5-9040-16e2a41f9695", "0de5c4f5-314e-4538-bd56-7360163b1fb0", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03c62728-bffb-421d-8f9c-9144351f8308");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a6ddc40-2be6-48c5-9040-16e2a41f9695");

            migrationBuilder.DropColumn(
                name: "Pickups",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VacationHoldStart",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VacationHoldEnd",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d98ed6fd-dfb7-4778-8301-206229ec18b9", "952d228b-0523-4f11-bfeb-7884c53829d4", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea183b3b-0e7d-4c98-9259-d4ca2565bbd3", "650b030f-83a2-4b9f-ae1e-0e56618a3f6a", "Customer", "CUSTOMER" });
        }
    }
}
