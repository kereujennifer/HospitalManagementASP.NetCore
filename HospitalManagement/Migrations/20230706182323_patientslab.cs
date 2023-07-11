using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class patientslab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laboratory_Patient_PatientId",
                table: "Laboratory");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Laboratory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratory_Patient_PatientId",
                table: "Laboratory",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laboratory_Patient_PatientId",
                table: "Laboratory");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Laboratory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratory_Patient_PatientId",
                table: "Laboratory",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
