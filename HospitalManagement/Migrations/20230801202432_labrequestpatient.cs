using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class labrequestpatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "LabRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LabRequests_PatientId",
                table: "LabRequests",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabRequests_Patient_PatientId",
                table: "LabRequests",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabRequests_Patient_PatientId",
                table: "LabRequests");

            migrationBuilder.DropIndex(
                name: "IX_LabRequests_PatientId",
                table: "LabRequests");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "LabRequests");
        }
    }
}
