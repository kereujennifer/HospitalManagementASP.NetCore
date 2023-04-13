using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class pharmacysupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_MedicineId",
                table: "Pharmacy",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_SupplierId",
                table: "Pharmacy",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineId",
                table: "Pharmacy",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Supplier_SupplierId",
                table: "Pharmacy",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineId",
                table: "Pharmacy");

            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Supplier_SupplierId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_MedicineId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_SupplierId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Pharmacy");
        }
    }
}
