using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddCollectedDateFieldToPrescriptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Used",
                table: "Prescription",
                newName: "IsCollected");

            migrationBuilder.AddColumn<DateTime>(
                name: "CollectedDate",
                table: "Prescription",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectedDate",
                table: "Prescription");

            migrationBuilder.RenameColumn(
                name: "IsCollected",
                table: "Prescription",
                newName: "Used");
        }
    }
}
