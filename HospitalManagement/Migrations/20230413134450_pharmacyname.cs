using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class pharmacyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineId",
                table: "Pharmacy");

            migrationBuilder.RenameColumn(
                name: "MedicineId",
                table: "Pharmacy",
                newName: "MedicineNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Pharmacy_MedicineId",
                table: "Pharmacy",
                newName: "IX_Pharmacy_MedicineNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineNameId",
                table: "Pharmacy",
                column: "MedicineNameId",
                principalTable: "Medicine",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineNameId",
                table: "Pharmacy");

            migrationBuilder.RenameColumn(
                name: "MedicineNameId",
                table: "Pharmacy",
                newName: "MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_Pharmacy_MedicineNameId",
                table: "Pharmacy",
                newName: "IX_Pharmacy_MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineId",
                table: "Pharmacy",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id");
        }
    }
}
