using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_Patient_PatientsId",
                table: "LabResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistory_Patient_PatientsId",
                table: "MedicalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineReports_Pharmacy_PharmacyId",
                table: "MedicineReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patient_PatientNameId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_Patient_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Laboratory");

            migrationBuilder.DropTable(
                name: "OutPatient");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pharmacy",
                table: "Pharmacy");

            migrationBuilder.RenameTable(
                name: "Pharmacy",
                newName: "HospitalMngt");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPrice",
                table: "HospitalMngt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "HospitalMngt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "HospitalMngt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Batch",
                table: "HospitalMngt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdmittingDoctor",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BMI",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bed",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BedCategory",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BedNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodPressure",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDispendsed",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DayShift",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discharge",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmploymentStatus",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndShift",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Equipment",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Floor",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloorNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Floors",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOccupied",
                table: "HospitalMngt",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicinePrescription",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextOfKin",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinAddress",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinPhone",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NightShift",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutPatient_Address",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutPatient_Email",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutPatient_FirstName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutPatient_LastName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutPatient_Phone",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentGuardianName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "HospitalMngt",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientNameId",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientType",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Address",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_AdmittingDoctor",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Patients_Age",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Patients_AppointmentId",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_BMI",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_BloodPressure",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Patients_DateDispendsed",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Patients_DateOfBirth",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Discharge",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Email",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_EmploymentStatus",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_FirstName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Gender",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Height",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_LastName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_MaritalStatus",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_MiddleName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_NextOfKin",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_NextOfKinAddress",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_NextOfKinName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_NextOfKinPhone",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_ParentGuardianName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Patients_PatientNameId",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Payment",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Phone",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Patients_RegDate",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_RegistrationNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Temprature",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Patients_UnderEighteen",
                table: "HospitalMngt",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Weight",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Payment",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegDate",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Report",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartShift",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Temprature",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestPerformed",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestPerformedBy",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestType",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UnderEighteen",
                table: "HospitalMngt",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ward",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WardCategory",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WardNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HospitalMngt",
                table: "HospitalMngt",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMngt_AppointmentId",
                table: "HospitalMngt",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMngt_PatientId",
                table: "HospitalMngt",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMngt_PatientNameId",
                table: "HospitalMngt",
                column: "PatientNameId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMngt_Patients_AppointmentId",
                table: "HospitalMngt",
                column: "Patients_AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt",
                column: "Patients_PatientNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_Appointments_AppointmentId",
                table: "HospitalMngt",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_Appointments_Patients_AppointmentId",
                table: "HospitalMngt",
                column: "Patients_AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_AspNetUsers_PatientId",
                table: "HospitalMngt",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_PatientNameId",
                table: "HospitalMngt",
                column: "PatientNameId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt",
                column: "Patients_PatientNameId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LabResults_HospitalMngt_PatientsId",
                table: "LabResults",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistory_HospitalMngt_PatientsId",
                table: "MedicalHistory",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineReports_HospitalMngt_PharmacyId",
                table: "MedicineReports",
                column: "PharmacyId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_HospitalMngt_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_HospitalMngt_PatientNameId",
                table: "Prescriptions",
                column: "PatientNameId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_HospitalMngt_PatientsId",
                table: "VitalSigns",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_Appointments_AppointmentId",
                table: "HospitalMngt");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_Appointments_Patients_AppointmentId",
                table: "HospitalMngt");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_AspNetUsers_PatientId",
                table: "HospitalMngt");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_HospitalMngt_PatientsId",
                table: "LabResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistory_HospitalMngt_PatientsId",
                table: "MedicalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineReports_HospitalMngt_PharmacyId",
                table: "MedicineReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_HospitalMngt_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_HospitalMngt_PatientNameId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_HospitalMngt_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HospitalMngt",
                table: "HospitalMngt");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMngt_AppointmentId",
                table: "HospitalMngt");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMngt_PatientId",
                table: "HospitalMngt");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMngt_PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMngt_Patients_AppointmentId",
                table: "HospitalMngt");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "AdmittingDoctor",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "BMI",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Bed",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "BedCategory",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "BedNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "BloodPressure",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "DateDispendsed",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "DayShift",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Discharge",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "EmploymentStatus",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "EndShift",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Equipment",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "FloorNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Floors",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "IsOccupied",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "MedicinePrescription",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "NextOfKin",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "NextOfKinAddress",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "NextOfKinName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "NextOfKinPhone",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "NightShift",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "OutPatient_Address",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "OutPatient_Email",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "OutPatient_FirstName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "OutPatient_LastName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "OutPatient_Phone",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "ParentGuardianName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "PatientType",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Address",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_AdmittingDoctor",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Age",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_AppointmentId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_BMI",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_BloodPressure",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_DateDispendsed",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_DateOfBirth",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Discharge",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Email",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_EmploymentStatus",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_FirstName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Gender",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Height",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_LastName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_MaritalStatus",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_MiddleName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_NextOfKin",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_NextOfKinAddress",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_NextOfKinName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_NextOfKinPhone",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_ParentGuardianName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Payment",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Phone",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_RegDate",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_RegistrationNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Temprature",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_UnderEighteen",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Weight",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "RegDate",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Report",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "StartShift",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Temprature",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "TestPerformed",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "TestPerformedBy",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "TestType",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "UnderEighteen",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Ward",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "WardCategory",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "WardNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "HospitalMngt");

            migrationBuilder.RenameTable(
                name: "HospitalMngt",
                newName: "Pharmacy");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPrice",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Stock",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Batch",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pharmacy",
                table: "Pharmacy",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentId = table.Column<int>(type: "int", nullable: true),
                    Beds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayShift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NightShift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartShift = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wards = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Laboratory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Beds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestPerformed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestPerformedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wards = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laboratory_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientNameId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmittingDoctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: true),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDispendsed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicinePrescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKinAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKinName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKinPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentGuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temprature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnderEighteen = table.Column<bool>(type: "bit", nullable: false),
                    WardCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Patient_PatientNameId",
                        column: x => x.PatientNameId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OutPatient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientNameId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmittingDoctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDispendsed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicinePrescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKinAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKinName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKinPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentGuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temprature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnderEighteen = table.Column<bool>(type: "bit", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutPatient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutPatient_Patient_PatientNameId",
                        column: x => x.PatientNameId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentId",
                table: "Doctors",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratory_PatientId",
                table: "Laboratory",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_OutPatient_PatientNameId",
                table: "OutPatient",
                column: "PatientNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AppointmentId",
                table: "Patient",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PatientNameId",
                table: "Patient",
                column: "PatientNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabResults_Patient_PatientsId",
                table: "LabResults",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistory_Patient_PatientsId",
                table: "MedicalHistory",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineReports_Pharmacy_PharmacyId",
                table: "MedicineReports",
                column: "PharmacyId",
                principalTable: "Pharmacy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patient_PatientNameId",
                table: "Prescriptions",
                column: "PatientNameId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VitalSigns_Patient_PatientsId",
                table: "VitalSigns",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");
        }
    }
}
