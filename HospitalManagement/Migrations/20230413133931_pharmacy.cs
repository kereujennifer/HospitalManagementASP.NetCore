using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class pharmacy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedicineName",
                table: "Pharmacy",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "MedicineCategory",
                table: "Pharmacy",
                newName: "UnitPrice");

            migrationBuilder.AddColumn<int>(
                name: "Batch",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Pharmacy",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientNameId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Pharmacy",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Batch",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "DateDispendsed",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "PatientNameId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Pharmacy");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Pharmacy",
                newName: "MedicineCategory");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Pharmacy",
                newName: "MedicineName");
        }
    }
}
