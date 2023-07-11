using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class prescriptionsdoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorsDoctorId",
                table: "Prescriptions");

            migrationBuilder.RenameColumn(
                name: "DoctorsDoctorId",
                table: "Prescriptions",
                newName: "DoctorsId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_DoctorsDoctorId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_DoctorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorsId",
                table: "Prescriptions",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorsId",
                table: "Prescriptions");

            migrationBuilder.RenameColumn(
                name: "DoctorsId",
                table: "Prescriptions",
                newName: "DoctorsDoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_DoctorsId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_DoctorsDoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorsDoctorId",
                table: "Prescriptions",
                column: "DoctorsDoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
