using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class morepatientdetails1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Patient",
                newName: "MaritalStatus");

            migrationBuilder.AddColumn<string>(
                name: "EmploymentStatus",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentStatus",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "MaritalStatus",
                table: "Patient",
                newName: "Occupation");
        }
    }
}
