using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hrpayrollwebapi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "PayrollDetails",
                columns: table => new
                {
                    PayrollId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollDetails", x => x.PayrollId);
                    table.ForeignKey(
                        name: "FK_PayrollDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BasicSalary", "FullName", "HireDate", "Position" },
                values: new object[,]
                {
                    { 1, 50000m, "Tarif Hossain", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager" },
                    { 2, 40000m, "Ashraf Uddin", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer" },
                    { 3, 35000m, "Abul Bashar Emon", new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Officer" },
                    { 4, 37000m, "Ahsanul Kabir", new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accountant" },
                    { 5, 42000m, "Abdur Rahim", new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Executive" }
                });

            migrationBuilder.InsertData(
                table: "PayrollDetails",
                columns: new[] { "PayrollId", "Deductions", "EmployeeId", "GrossSalary", "NetSalary", "PayMonth" },
                values: new object[,]
                {
                    { 1, 2000m, 1, 52000m, 50000m, "December 2024" },
                    { 2, 2000m, 2, 42000m, 40000m, "December 2024" },
                    { 3, 2000m, 3, 37000m, 35000m, "December 2024" },
                    { 4, 2000m, 4, 39000m, 37000m, "December 2024" },
                    { 5, 2000m, 5, 44000m, 42000m, "December 2024" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayrollDetails_EmployeeId",
                table: "PayrollDetails",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayrollDetails");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
