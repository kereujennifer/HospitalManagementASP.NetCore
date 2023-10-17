using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trialTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabRequestId",
                table: "LabResults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_LabRequestId",
                table: "LabResults",
                column: "LabRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabResults_LabRequests_LabRequestId",
                table: "LabResults",
                column: "LabRequestId",
                principalTable: "LabRequests",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_LabRequests_LabRequestId",
                table: "LabResults");

            migrationBuilder.DropIndex(
                name: "IX_LabResults_LabRequestId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "LabRequestId",
                table: "LabResults");
        }
    }
}
