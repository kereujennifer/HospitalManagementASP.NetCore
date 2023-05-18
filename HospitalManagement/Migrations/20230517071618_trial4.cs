using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temprature",
                table: "VitalSigns",
                newName: "Temperature");

            migrationBuilder.RenameColumn(
                name: "DateDispendsed",
                table: "Prescriptions",
                newName: "DateDispensed");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "HospitalMngt",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMngt_PrescriptionId",
                table: "HospitalMngt",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMngt_Prescriptions_PrescriptionId",
                table: "HospitalMngt",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMngt_Prescriptions_PrescriptionId",
                table: "HospitalMngt");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMngt_PrescriptionId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "HospitalMngt");

            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "VitalSigns",
                newName: "Temprature");

            migrationBuilder.RenameColumn(
                name: "DateDispensed",
                table: "Prescriptions",
                newName: "DateDispendsed");
        }
    }
}
