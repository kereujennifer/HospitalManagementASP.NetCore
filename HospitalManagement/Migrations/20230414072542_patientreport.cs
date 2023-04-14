using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class patientreport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BMI",
                table: "PatientReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodPressure",
                table: "PatientReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "PatientReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Temprature",
                table: "PatientReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "PatientReports",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BMI",
                table: "PatientReports");

            migrationBuilder.DropColumn(
                name: "BloodPressure",
                table: "PatientReports");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "PatientReports");

            migrationBuilder.DropColumn(
                name: "Temprature",
                table: "PatientReports");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "PatientReports");
        }
    }
}
