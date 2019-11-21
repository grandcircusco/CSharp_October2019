using Microsoft.EntityFrameworkCore.Migrations;

namespace Day_28___EFCoreCodeFirst1.Migrations
{
    public partial class addedOrphanDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "Budget", "Location", "Name", "Type" },
                values: new object[] { 0.0, "Not found", "Orphan Employees", "Lost" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "Budget", "Location", "Name", "Type" },
                values: new object[] { 0.29999999999999999, "East Wing", "Accounting", "Finance" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "Budget", "Location", "Name", "Type" },
                values: new object[] { 5000000.0, "West Wing", "Marketing", "Advertising" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Budget", "Location", "Name", "Type" },
                values: new object[] { 4, 16.0, "Sales Floor", "Sales", "Peons" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "Budget", "Location", "Name", "Type" },
                values: new object[] { 0.29999999999999999, "East Wing", "Accounting", "Finance" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "Budget", "Location", "Name", "Type" },
                values: new object[] { 5000000.0, "West Wing", "Marketing", "Advertising" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "Budget", "Location", "Name", "Type" },
                values: new object[] { 16.0, "Sales Floor", "Sales", "Peons" });
        }
    }
}
