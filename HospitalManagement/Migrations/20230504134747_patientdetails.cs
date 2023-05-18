using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class patientdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateDispendsed",
                table: "Patient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicinePrescription",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientNameId",
                table: "Patient",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PatientNameId",
                table: "Patient",
                column: "PatientNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patient_PatientNameId",
                table: "Patient",
                column: "PatientNameId",
                principalTable: "Patient",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patient_PatientNameId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_PatientNameId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "DateDispendsed",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "MedicinePrescription",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "PatientNameId",
                table: "Patient");
        }
    }
}
