using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class morepatientdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinAddress",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextOfKinName",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Payment",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegDate",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RegistrationNumber",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "VitalSigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temprature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalSigns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VitalSigns");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "NextOfKinAddress",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "NextOfKinName",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "RegDate",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Patient");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
