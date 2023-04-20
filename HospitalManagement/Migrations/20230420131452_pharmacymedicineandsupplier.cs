using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class pharmacymedicineandsupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineNameId",
                table: "Pharmacy");

            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacy_Supplier_SupplierId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_MedicineNameId",
                table: "Pharmacy");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacy_SupplierId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "MedicineNameId",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Pharmacy");

            migrationBuilder.AddColumn<string>(
                name: "MedicineName",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supplier",
                table: "Pharmacy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicineName",
                table: "Pharmacy");

            migrationBuilder.DropColumn(
                name: "Supplier",
                table: "Pharmacy");

            migrationBuilder.AddColumn<int>(
                name: "MedicineNameId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Pharmacy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_MedicineNameId",
                table: "Pharmacy",
                column: "MedicineNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_SupplierId",
                table: "Pharmacy",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Medicine_MedicineNameId",
                table: "Pharmacy",
                column: "MedicineNameId",
                principalTable: "Medicine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacy_Supplier_SupplierId",
                table: "Pharmacy",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");
        }
    }
}
