using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trialFive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabTestCategory_LabTest_LabTestId",
                table: "LabTestCategory");

            migrationBuilder.DropIndex(
                name: "IX_LabTestCategory_LabTestId",
                table: "LabTestCategory");

            migrationBuilder.DropColumn(
                name: "LabTestId",
                table: "LabTestCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "LabTest");

            migrationBuilder.AddColumn<int>(
                name: "LabTestCategoryId",
                table: "LabTest",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabTest_LabTestCategoryId",
                table: "LabTest",
                column: "LabTestCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabTest_LabTestCategory_LabTestCategoryId",
                table: "LabTest",
                column: "LabTestCategoryId",
                principalTable: "LabTestCategory",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabTest_LabTestCategory_LabTestCategoryId",
                table: "LabTest");

            migrationBuilder.DropIndex(
                name: "IX_LabTest_LabTestCategoryId",
                table: "LabTest");

            migrationBuilder.DropColumn(
                name: "LabTestCategoryId",
                table: "LabTest");

            migrationBuilder.AddColumn<int>(
                name: "LabTestId",
                table: "LabTestCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "LabTest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LabTestCategory_LabTestId",
                table: "LabTestCategory",
                column: "LabTestId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabTestCategory_LabTest_LabTestId",
                table: "LabTestCategory",
                column: "LabTestId",
                principalTable: "LabTest",
                principalColumn: "Id");
        }
    }
}
