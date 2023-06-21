using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class tetst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Prescriptions_PrescriptionId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_Patient_PatientsId",
                table: "LabResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistories_Patient_PatientsId",
                table: "MedicalHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");


            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_Patient_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_VitalSigns_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions");

      

            migrationBuilder.DropIndex(
                name: "IX_MedicalHistories_PatientsId",
                table: "MedicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_LabResults_PatientsId",
                table: "LabResults");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PrescriptionId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Prescriptions");

       

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "VitalSigns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "Prescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorsDoctorId",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Prescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "MedicalHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "LabResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "LabResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VitalSigns_PatientId",
                table: "VitalSigns",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorsDoctorId",
                table: "Prescriptions",
                column: "DoctorsDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_PatientId",
                table: "MedicalHistories",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_PatientId",
                table: "LabResults",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabResults_Patient_PatientId",
                table: "LabResults",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistories_Patient_PatientId",
                table: "MedicalHistories",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorsDoctorId",
                table: "Prescriptions",
                column: "DoctorsDoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patient_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_Patient_PatientId",
                table: "VitalSigns",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_Patient_PatientId",
                table: "LabResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistories_Patient_PatientId",
                table: "MedicalHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorsDoctorId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patient_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_Patient_PatientId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_VitalSigns_PatientId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DoctorsDoctorId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_MedicalHistories_PatientId",
                table: "MedicalHistories");

            migrationBuilder.DropIndex(
                name: "IX_LabResults_PatientId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "VitalSigns");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DoctorsDoctorId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "LabResults");

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "VitalSigns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientNameId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "MedicalHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "LabResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VitalSigns_PatientsId",
                table: "VitalSigns",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                column: "DoctorId");

       

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_PatientsId",
                table: "MedicalHistories",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_PatientsId",
                table: "LabResults",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PrescriptionId",
                table: "Doctors",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Prescriptions_PrescriptionId",
                table: "Doctors",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LabResults_Patient_PatientsId",
                table: "LabResults",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistories_Patient_PatientsId",
                table: "MedicalHistories",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");

          

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_Patient_PatientsId",
                table: "VitalSigns",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");
        }
    }
}
