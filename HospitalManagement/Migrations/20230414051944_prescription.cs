using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class prescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Doctors_DoctorId",
                table: "Pharmacy");

            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Patient_PatientNameId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_DoctorId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_PatientNameId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "DateDispendsed",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "MedicinePrescription",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "PatientNameId",
                table: "Pharmacy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateDispendsed",
                table: "Pharmacy",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicinePrescription",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientNameId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_DoctorId",
                table: "Pharmacy",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_PatientNameId",
                table: "Pharmacy",
                column: "PatientNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Doctors_DoctorId",
                table: "Pharmacy",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Patient_PatientNameId",
                table: "Pharmacy",
                column: "PatientNameId",
                principalTable: "Patient",
                principalColumn: "Id");
        }
    }
}
