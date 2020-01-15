using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartementAspCore.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departements_Employees_DepID",
                table: "departements");

            migrationBuilder.DropIndex(
                name: "IX_departements_DepID",
                table: "departements");

            migrationBuilder.DropColumn(
                name: "DepID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepID",
                table: "departements");

            migrationBuilder.AddColumn<int>(
                name: "EmpID",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpID",
                table: "departements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmpID",
                table: "Employees",
                column: "EmpID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_departements_EmpID",
                table: "Employees",
                column: "EmpID",
                principalTable: "departements",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_departements_EmpID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmpID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpID",
                table: "departements");

            migrationBuilder.AddColumn<int>(
                name: "DepID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepID",
                table: "departements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_departements_DepID",
                table: "departements",
                column: "DepID");

            migrationBuilder.AddForeignKey(
                name: "FK_departements_Employees_DepID",
                table: "departements",
                column: "DepID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
