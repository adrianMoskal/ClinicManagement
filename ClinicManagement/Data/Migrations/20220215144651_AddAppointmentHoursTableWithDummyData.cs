using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddAppointmentHoursTableWithDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentHours",
                columns: table => new
                {
                    AppointmentHourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hour = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentHours", x => x.AppointmentHourId);
                });

            migrationBuilder.InsertData(
                table: "AppointmentHours",
                columns: new[] { "AppointmentHourId", "Hour" },
                values: new object[,]
                {
                    { 1, "8:00" },
                    { 16, "15:30" },
                    { 15, "15:00" },
                    { 14, "14:30" },
                    { 13, "14:00" },
                    { 12, "13:30" },
                    { 11, "13:00" },
                    { 9, "12:00" },
                    { 10, "12:30" },
                    { 7, "11:00" },
                    { 6, "10:30" },
                    { 5, "10:00" },
                    { 4, "9:30" },
                    { 3, "9:00" },
                    { 2, "8:30" },
                    { 8, "11:30" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentHours_Hour",
                table: "AppointmentHours",
                column: "Hour",
                unique: true,
                filter: "[Hour] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentHours");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 31, 22, 40, 52, 951, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 2, 2, 22, 40, 52, 954, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 2, 4, 22, 40, 52, 954, DateTimeKind.Local).AddTicks(3097));
        }
    }
}
