using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "BedNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "FloorNumber",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "PatientType",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_AdmittingDoctor",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_DateDispendsed",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "Patients_Discharge",
                table: "HospitalMngt");

            migrationBuilder.RenameColumn(
                name: "WardNumber",
                table: "HospitalMngt",
                newName: "Prescription");

            migrationBuilder.RenameColumn(
                name: "Patients_PatientNameId",
                table: "HospitalMngt",
                newName: "PatientsId");

            migrationBuilder.RenameColumn(
                name: "Patients_MedicinePrescription",
                table: "HospitalMngt",
                newName: "DateDispensed");

            migrationBuilder.RenameIndex(
                name: "IX_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt",
                newName: "IX_HospitalMngt_PatientsId");

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
                name: "FK_HospitalMngt_HospitalMngt_PatientsId",
                table: "HospitalMngt",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_PatientsId",
                table: "HospitalMngt");

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

            migrationBuilder.RenameColumn(
                name: "Prescription",
                table: "HospitalMngt",
                newName: "WardNumber");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "HospitalMngt",
                newName: "Patients_PatientNameId");

            migrationBuilder.RenameColumn(
                name: "DateDispensed",
                table: "HospitalMngt",
                newName: "Patients_MedicinePrescription");

            migrationBuilder.RenameIndex(
                name: "IX_HospitalMngt_PatientsId",
                table: "HospitalMngt",
                newName: "IX_HospitalMngt_Patients_PatientNameId");

            migrationBuilder.AddColumn<string>(
                name: "BedNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloorNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientType",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_AdmittingDoctor",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Patients_DateDispendsed",
                table: "HospitalMngt",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Patients_Discharge",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_HospitalMngt_Patients_PatientNameId",
                table: "HospitalMngt",
                column: "Patients_PatientNameId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");
        }
    }
}
