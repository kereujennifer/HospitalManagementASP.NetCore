using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class trialOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabRequests_Laboratory_LaboratoryId",
                table: "LabRequests");

            migrationBuilder.DropIndex(
                name: "IX_LabRequests_LaboratoryId",
                table: "LabRequests");

            migrationBuilder.DropColumn(
                name: "LaboratoryId",
                table: "LabRequests");

            migrationBuilder.AddColumn<int>(
                name: "LabResultId",
                table: "Laboratory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LabRequestLaboratory",
                columns: table => new
                {
                    LabRequestId = table.Column<int>(type: "int", nullable: false),
                    LaboratoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabRequestLaboratory", x => new { x.LabRequestId, x.LaboratoryId });
                    table.ForeignKey(
                        name: "FK_LabRequestLaboratory_Laboratory_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "Laboratory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabRequestLaboratory_LabRequests_LabRequestId",
                        column: x => x.LabRequestId,
                        principalTable: "LabRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabRequestLaboratory_LaboratoryId",
                table: "LabRequestLaboratory",
                column: "LaboratoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabRequestLaboratory");

            migrationBuilder.DropColumn(
                name: "LabResultId",
                table: "Laboratory");

            migrationBuilder.AddColumn<int>(
                name: "LaboratoryId",
                table: "LabRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabRequests_LaboratoryId",
                table: "LabRequests",
                column: "LaboratoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabRequests_Laboratory_LaboratoryId",
                table: "LabRequests",
                column: "LaboratoryId",
                principalTable: "Laboratory",
                principalColumn: "Id");
        }
    }
}
