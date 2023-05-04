using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class doctorandnurse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "VitalSigns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beds",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stations",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wards",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beds",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stations",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wards",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "MedicalHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsId",
                table: "LabResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beds",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Equipment",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stations",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestType",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wards",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beds",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DayShift",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndShift",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NightShift",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartShift",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Stations",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wards",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VitalSigns_PatientsId",
                table: "VitalSigns",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistory_PatientsId",
                table: "MedicalHistory",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_PatientsId",
                table: "LabResults",
                column: "PatientsId");

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
                name: "FK_VitalSigns_Patient_PatientsId",
                table: "VitalSigns",
                column: "PatientsId",
                principalTable: "Patient",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabResults_Patient_PatientsId",
                table: "LabResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistory_Patient_PatientsId",
                table: "MedicalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VitalSigns_Patient_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_VitalSigns_PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropIndex(
                name: "IX_MedicalHistory_PatientsId",
                table: "MedicalHistory");

            migrationBuilder.DropIndex(
                name: "IX_LabResults_PatientsId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "VitalSigns");

            migrationBuilder.DropColumn(
                name: "Beds",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Stations",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Wards",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Beds",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Stations",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Wards",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "MedicalHistory");

            migrationBuilder.DropColumn(
                name: "PatientsId",
                table: "LabResults");

            migrationBuilder.DropColumn(
                name: "Beds",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Equipment",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Stations",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "TestType",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Wards",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Beds",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DayShift",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "EndShift",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "NightShift",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "StartShift",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Stations",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Wards",
                table: "Doctors");
        }
    }
}
