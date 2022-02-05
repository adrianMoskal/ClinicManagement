using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddSpecialtiesAndUserSpecialtiesTablesWithDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    SpecialtyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.SpecialtyId);
                });

            migrationBuilder.CreateTable(
                name: "UserSpecialties",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecialtyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSpecialties", x => new { x.UserId, x.SpecialtyId });
                    table.ForeignKey(
                        name: "FK_UserSpecialties_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "SpecialtyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSpecialties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "SpecialtyId", "Name" },
                values: new object[,]
                {
                    { 14, "Urology" },
                    { 13, "Rheumatology" },
                    { 12, "Psychiatry" },
                    { 11, "Pediatrics" },
                    { 10, "Pathology" },
                    { 9, "Hematology" },
                    { 7, "Hematology" },
                    { 6, "Geriatrics" },
                    { 5, "Family medicine" },
                    { 4, "Endocrinology" },
                    { 3, "Dermatology" },
                    { 2, "Cardiology" },
                    { 8, "Neurology" },
                    { 1, "Allergy and immunology" }
                });

            migrationBuilder.InsertData(
                table: "UserSpecialties",
                columns: new[] { "SpecialtyId", "UserId" },
                values: new object[,]
                {
                    { 2, "80d10f83-f746-4397-a76f-fa2a216833bc" },
                    { 5, "6ca24cbc-8085-475b-8bee-b3c09575561e" },
                    { 5, "40ae9fef-c94e-4823-a4da-bd1686467689" },
                    { 13, "80d10f83-f746-4397-a76f-fa2a216833bc" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSpecialties_SpecialtyId",
                table: "UserSpecialties",
                column: "SpecialtyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSpecialties");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 29, 14, 43, 38, 361, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 31, 14, 43, 38, 362, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 2, 2, 14, 43, 38, 362, DateTimeKind.Local).AddTicks(9651));
        }
    }
}
