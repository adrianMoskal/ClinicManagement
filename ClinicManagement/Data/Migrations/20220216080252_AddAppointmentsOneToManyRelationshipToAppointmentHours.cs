using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddAppointmentsOneToManyRelationshipToAppointmentHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentHourId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                columns: new[] { "AppointmentHourId", "Date" },
                values: new object[] { 5, new DateTime(2022, 2, 11, 9, 2, 52, 412, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                columns: new[] { "AppointmentHourId", "Date" },
                values: new object[] { 2, new DateTime(2022, 2, 13, 9, 2, 52, 413, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                columns: new[] { "AppointmentHourId", "Date" },
                values: new object[] { 7, new DateTime(2022, 2, 15, 9, 2, 52, 413, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppointmentHourId",
                table: "Appointments",
                column: "AppointmentHourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentHours_AppointmentHourId",
                table: "Appointments",
                column: "AppointmentHourId",
                principalTable: "AppointmentHours",
                principalColumn: "AppointmentHourId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentHours_AppointmentHourId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_AppointmentHourId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentHourId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 2, 10, 15, 46, 51, 150, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 2, 12, 15, 46, 51, 151, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 2, 14, 15, 46, 51, 151, DateTimeKind.Local).AddTicks(2922));
        }
    }
}
