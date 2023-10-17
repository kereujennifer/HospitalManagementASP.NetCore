using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trialThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabRequestId",
                table: "Laboratory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LabRequestId",
                table: "Laboratory");
        }
    }
}
