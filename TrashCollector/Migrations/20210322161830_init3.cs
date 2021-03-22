using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2d1a91d-4da1-41e4-b2a1-767ebef65523");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b06a60f1-657e-4704-b180-b78a99b15f37");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "Customers");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtraPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PickUpDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VacationHoldEnd",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "VacationHoldStart",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d98ed6fd-dfb7-4778-8301-206229ec18b9", "952d228b-0523-4f11-bfeb-7884c53829d4", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea183b3b-0e7d-4c98-9259-d4ca2565bbd3", "650b030f-83a2-4b9f-ae1e-0e56618a3f6a", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d98ed6fd-dfb7-4778-8301-206229ec18b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea183b3b-0e7d-4c98-9259-d4ca2565bbd3");

            migrationBuilder.DropColumn(
                name: "ExtraPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VacationHoldEnd",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VacationHoldStart",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b06a60f1-657e-4704-b180-b78a99b15f37", "f375de1a-80e8-4e92-821a-349a2a26243d", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2d1a91d-4da1-41e4-b2a1-767ebef65523", "a7c4ea94-9d8b-4929-9c8c-9d73e90af627", "Customer", "CUSTOMER" });
        }
    }
}
