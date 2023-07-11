using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class labandstaffinlabresults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabResultsId",
                table: "Staff",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LabResultsId",
                table: "Laboratory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_LabResultsId",
                table: "Staff",
                column: "LabResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratory_LabResultsId",
                table: "Laboratory",
                column: "LabResultsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratory_LabResults_LabResultsId",
                table: "Laboratory",
                column: "LabResultsId",
                principalTable: "LabResults",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_LabResults_LabResultsId",
                table: "Staff",
                column: "LabResultsId",
                principalTable: "LabResults",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laboratory_LabResults_LabResultsId",
                table: "Laboratory");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_LabResults_LabResultsId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_LabResultsId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Laboratory_LabResultsId",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "LabResultsId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "LabResultsId",
                table: "Laboratory");
        }
    }
}
