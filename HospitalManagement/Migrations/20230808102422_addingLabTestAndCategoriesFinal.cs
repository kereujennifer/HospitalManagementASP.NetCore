using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class addingLabTestAndCategoriesFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabTestCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabTestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabTestCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabTestCategory_LabTest_LabTestId",
                        column: x => x.LabTestId,
                        principalTable: "LabTest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabTestCategory_LabTestId",
                table: "LabTestCategory",
                column: "LabTestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabTestCategory");

            migrationBuilder.DropTable(
                name: "LabTest");
        }
    }
}
