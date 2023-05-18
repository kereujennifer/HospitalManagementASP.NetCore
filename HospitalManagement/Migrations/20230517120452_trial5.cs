using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "MedicalHistories");

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
                name: "WardNumber",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "WardNumber",
                table: "HospitalMngt");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
