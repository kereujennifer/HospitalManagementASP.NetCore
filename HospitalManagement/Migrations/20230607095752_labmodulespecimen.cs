using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class labmodulespecimen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CollectionInstructions",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollectionSite",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionInstructions",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "CollectionSite",
                table: "Laboratory");

     
        }
    }
}
