using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trialSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabTest_LabTestCategory_LabTestCategoryId",
                table: "LabTest");

            migrationBuilder.RenameColumn(
                name: "LabTestCategoryId",
                table: "LabTest",
                newName: "LabTestCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_LabTest_LabTestCategoryId",
                table: "LabTest",
                newName: "IX_LabTest_LabTestCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_LabTest_LabTestCategory_LabTestCategoryID",
                table: "LabTest",
                column: "LabTestCategoryID",
                principalTable: "LabTestCategory",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabTest_LabTestCategory_LabTestCategoryID",
                table: "LabTest");

            migrationBuilder.RenameColumn(
                name: "LabTestCategoryID",
                table: "LabTest",
                newName: "LabTestCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_LabTest_LabTestCategoryID",
                table: "LabTest",
                newName: "IX_LabTest_LabTestCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabTest_LabTestCategory_LabTestCategoryId",
                table: "LabTest",
                column: "LabTestCategoryId",
                principalTable: "LabTestCategory",
                principalColumn: "Id");
        }
    }
}
