using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class MakeModificationDateFieldNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UserSpecialty");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Specialty");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AppointmentHour");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Appointment");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "UserSpecialty",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Specialty",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "AppointmentHour",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "Appointment",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "UserSpecialty");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Specialty");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "AppointmentHour");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "Appointment");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserSpecialty",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Specialty",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AppointmentHour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
