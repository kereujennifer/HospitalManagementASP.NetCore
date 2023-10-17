using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class scaffoldHospitalmngt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Room",
                table: "HospitalMngt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
