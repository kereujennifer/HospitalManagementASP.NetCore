using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagement.Migrations
{
    public partial class SaveMedicalHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistory_HospitalMngt_PatientsId",
                table: "MedicalHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalHistory",
                table: "MedicalHistory");

            migrationBuilder.RenameTable(
                name: "MedicalHistory",
                newName: "MedicalHistories");

            migrationBuilder.RenameColumn(
                name: "Medications",
                table: "MedicalHistories",
                newName: "SurgicalProcedures");

            migrationBuilder.RenameColumn(
                name: "MedicalCondition",
                table: "MedicalHistories",
                newName: "SocialHistory");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalHistory_PatientsId",
                table: "MedicalHistories",
                newName: "IX_MedicalHistories_PatientsId");

            migrationBuilder.AddColumn<string>(
                name: "FamilyHistory",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnMedications",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastMedicalConditions",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "MedicalHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalHistories",
                table: "MedicalHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistories_HospitalMngt_PatientsId",
                table: "MedicalHistories",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalHistories_HospitalMngt_PatientsId",
                table: "MedicalHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalHistories",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "FamilyHistory",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "OnMedications",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "PastMedicalConditions",
                table: "MedicalHistories");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "MedicalHistories");

            migrationBuilder.RenameTable(
                name: "MedicalHistories",
                newName: "MedicalHistory");

            migrationBuilder.RenameColumn(
                name: "SurgicalProcedures",
                table: "MedicalHistory",
                newName: "Medications");

            migrationBuilder.RenameColumn(
                name: "SocialHistory",
                table: "MedicalHistory",
                newName: "MedicalCondition");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalHistories_PatientsId",
                table: "MedicalHistory",
                newName: "IX_MedicalHistory_PatientsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalHistory",
                table: "MedicalHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalHistory_HospitalMngt_PatientsId",
                table: "MedicalHistory",
                column: "PatientsId",
                principalTable: "HospitalMngt",
                principalColumn: "Id");
        }
    }
}
