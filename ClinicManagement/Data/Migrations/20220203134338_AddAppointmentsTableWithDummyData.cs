using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddAppointmentsTableWithDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Date", "DoctorId", "PatientId" },
                values: new object[] { 1, new DateTime(2022, 1, 29, 14, 43, 38, 361, DateTimeKind.Local).AddTicks(6702), "6ca24cbc-8085-475b-8bee-b3c09575561e", "cc033eab-8a7e-4c70-8a87-1aee071141a4" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Date", "DoctorId", "PatientId" },
                values: new object[] { 2, new DateTime(2022, 1, 31, 14, 43, 38, 362, DateTimeKind.Local).AddTicks(9632), "6ca24cbc-8085-475b-8bee-b3c09575561e", "cc033eab-8a7e-4c70-8a87-1aee071141a4" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Date", "DoctorId", "PatientId" },
                values: new object[] { 3, new DateTime(2022, 2, 2, 14, 43, 38, 362, DateTimeKind.Local).AddTicks(9651), "40ae9fef-c94e-4823-a4da-bd1686467689", "cc033eab-8a7e-4c70-8a87-1aee071141a4" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
