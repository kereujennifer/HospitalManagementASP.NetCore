using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class HospitalManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BedId",
                table: "HospitalMngt",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomType",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "HospitalMngt",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "HospitalMngt",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WardName",
                table: "HospitalMngt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "RoomType",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "HospitalMngt");

            migrationBuilder.DropColumn(
                name: "WardName",
                table: "HospitalMngt");
        }
    }
}
