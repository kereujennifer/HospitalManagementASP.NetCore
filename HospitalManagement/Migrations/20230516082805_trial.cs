using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_HospitalMngt_PatientsId",
                table: "LabResults");

            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_HospitalMngt_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_VitalSigns_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_LabResults_PatientsId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "LabResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "VitalSigns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "LabResults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VitalSigns_PatientsId",
                table: "VitalSigns",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_PatientsId",
                table: "LabResults",
                column: "PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabResults_HospitalMngt_PatientsId",
                table: "LabResults",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_HospitalMngt_PatientsId",
                table: "VitalSigns",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");
        }
    }
}
