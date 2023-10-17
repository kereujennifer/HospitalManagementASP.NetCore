using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class labrequeststrial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LaboratoryId",
                table: "LabRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabRequests_LaboratoryId",
                table: "LabRequests",
                column: "LaboratoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabRequests_Laboratory_LaboratoryId",
                table: "LabRequests",
                column: "LaboratoryId",
                principalTable: "Laboratory",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabRequests_Laboratory_LaboratoryId",
                table: "LabRequests");

            migrationBuilder.DropIndex(
                name: "IX_LabRequests_LaboratoryId",
                table: "LabRequests");

            migrationBuilder.DropColumn(
                name: "LaboratoryId",
                table: "LabRequests");
        }
    }
}
