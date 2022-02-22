using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class UpdateEntitiesByGenericRepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSpecialties_Users_UserId",
                table: "UserSpecialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSpecialties",
                table: "UserSpecialties");

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumns: new[] { "SpecialtyId", "UserId" },
                keyValues: new object[] { 5, "40ae9fef-c94e-4823-a4da-bd1686467689" });

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumns: new[] { "SpecialtyId", "UserId" },
                keyValues: new object[] { 5, "6ca24cbc-8085-475b-8bee-b3c09575561e" });

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumns: new[] { "SpecialtyId", "UserId" },
                keyValues: new object[] { 2, "80d10f83-f746-4397-a76f-fa2a216833bc" });

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumns: new[] { "SpecialtyId", "UserId" },
                keyValues: new object[] { 13, "80d10f83-f746-4397-a76f-fa2a216833bc" });

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 13);

            migrationBuilder.AlterColumn<long>(
                name: "SpecialtyId",
                table: "UserSpecialties",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserSpecialties",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "UserSpecialtyId",
                table: "UserSpecialties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "UserSpecialties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserSpecialties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "SpecialtyId",
                table: "Specialties",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Specialties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Specialties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentHourId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentHourId",
                table: "AppointmentHours",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AppointmentHours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AppointmentHours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSpecialties",
                table: "UserSpecialties",
                column: "UserSpecialtyId");

            migrationBuilder.InsertData(
                table: "AppointmentHours",
                columns: new[] { "AppointmentHourId", "CreateDate", "Hour", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7550), "8:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7559) },
                    { 16L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7627), "15:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7630) },
                    { 14L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7619), "14:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7621) },
                    { 13L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7614), "14:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7616) },
                    { 12L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7610), "13:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7612) },
                    { 11L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7605), "13:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7607) },
                    { 10L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7600), "12:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7602) },
                    { 9L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7596), "12:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7598) },
                    { 15L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7623), "15:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7625) },
                    { 7L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7587), "11:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7589) },
                    { 6L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7582), "10:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7584) },
                    { 5L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7577), "10:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7579) },
                    { 4L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7573), "9:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7575) },
                    { 3L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7568), "9:00", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7570) },
                    { 2L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7564), "8:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7566) },
                    { 8L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7591), "11:30", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(7593) }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "SpecialtyId", "CreateDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 12L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5845), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5847), "Psychiatry" },
                    { 11L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5841), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5843), "Pediatrics" },
                    { 10L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5836), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5838), "Pathology" },
                    { 9L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5831), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5834), "Hematology" },
                    { 8L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5827), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5829), "Neurology" },
                    { 7L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5822), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5824), "Hematology" },
                    { 4L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5809), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5811), "Endocrinology" },
                    { 5L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5813), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5815), "Family medicine" },
                    { 3L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5804), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5806), "Dermatology" },
                    { 2L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5799), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5801), "Cardiology" },
                    { 1L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5785), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5794), "Allergy and immunology" },
                    { 13L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5852), "Rheumatology" },
                    { 6L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5818), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5820), "Geriatrics" },
                    { 14L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5854), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(5856), "Urology" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentHourId", "CreateDate", "Date", "DoctorId", "ModifiedDate", "PatientId" },
                values: new object[,]
                {
                    { 2L, 2L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 2, 19, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4912), "6ca24cbc-8085-475b-8bee-b3c09575561e", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4923), "cc033eab-8a7e-4c70-8a87-1aee071141a4" },
                    { 1L, 5L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 2, 17, 20, 19, 12, 442, DateTimeKind.Local).AddTicks(2750), "6ca24cbc-8085-475b-8bee-b3c09575561e", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4610), "cc033eab-8a7e-4c70-8a87-1aee071141a4" },
                    { 3L, 7L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4929), new DateTime(2022, 2, 21, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4927), "40ae9fef-c94e-4823-a4da-bd1686467689", new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(4931), "cc033eab-8a7e-4c70-8a87-1aee071141a4" }
                });

            migrationBuilder.InsertData(
                table: "UserSpecialties",
                columns: new[] { "UserSpecialtyId", "CreateDate", "ModifiedDate", "SpecialtyId", "UserId" },
                values: new object[,]
                {
                    { 3L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6885), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6888), 2L, "80d10f83-f746-4397-a76f-fa2a216833bc" },
                    { 1L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6867), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6876), 5L, "6ca24cbc-8085-475b-8bee-b3c09575561e" },
                    { 2L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6881), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6883), 5L, "40ae9fef-c94e-4823-a4da-bd1686467689" },
                    { 4L, new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6890), new DateTime(2022, 2, 22, 20, 19, 12, 444, DateTimeKind.Local).AddTicks(6892), 13L, "80d10f83-f746-4397-a76f-fa2a216833bc" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSpecialties_UserId",
                table: "UserSpecialties",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSpecialties_Users_UserId",
                table: "UserSpecialties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSpecialties_Users_UserId",
                table: "UserSpecialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSpecialties",
                table: "UserSpecialties");

            migrationBuilder.DropIndex(
                name: "IX_UserSpecialties_UserId",
                table: "UserSpecialties");

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumn: "UserSpecialtyId",
                keyColumnType: "bigint",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumn: "UserSpecialtyId",
                keyColumnType: "bigint",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumn: "UserSpecialtyId",
                keyColumnType: "bigint",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserSpecialties",
                keyColumn: "UserSpecialtyId",
                keyColumnType: "bigint",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AppointmentHours",
                keyColumn: "AppointmentHourId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Specialties",
                keyColumn: "SpecialtyId",
                keyValue: 13L);

            migrationBuilder.DropColumn(
                name: "UserSpecialtyId",
                table: "UserSpecialties");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "UserSpecialties");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UserSpecialties");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AppointmentHours");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AppointmentHours");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserSpecialties",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpecialtyId",
                table: "UserSpecialties",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialtyId",
                table: "Specialties",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentHourId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentHourId",
                table: "AppointmentHours",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSpecialties",
                table: "UserSpecialties",
                columns: new[] { "UserId", "SpecialtyId" });

            migrationBuilder.InsertData(
                table: "AppointmentHours",
                columns: new[] { "AppointmentHourId", "Hour" },
                values: new object[,]
                {
                    { 1, "8:00" },
                    { 16, "15:30" },
                    { 14, "14:30" },
                    { 13, "14:00" },
                    { 12, "13:30" },
                    { 11, "13:00" },
                    { 10, "12:30" },
                    { 9, "12:00" },
                    { 15, "15:00" },
                    { 7, "11:00" },
                    { 6, "10:30" },
                    { 5, "10:00" },
                    { 4, "9:30" },
                    { 3, "9:00" },
                    { 2, "8:30" },
                    { 8, "11:30" }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "SpecialtyId", "Name" },
                values: new object[,]
                {
                    { 12, "Psychiatry" },
                    { 11, "Pediatrics" },
                    { 10, "Pathology" },
                    { 9, "Hematology" },
                    { 8, "Neurology" },
                    { 7, "Hematology" },
                    { 4, "Endocrinology" },
                    { 5, "Family medicine" },
                    { 3, "Dermatology" },
                    { 2, "Cardiology" },
                    { 1, "Allergy and immunology" },
                    { 13, "Rheumatology" },
                    { 6, "Geriatrics" },
                    { 14, "Urology" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentHourId", "Date", "DoctorId", "PatientId" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2022, 2, 13, 9, 2, 52, 413, DateTimeKind.Local).AddTicks(3300), "6ca24cbc-8085-475b-8bee-b3c09575561e", "cc033eab-8a7e-4c70-8a87-1aee071141a4" },
                    { 1, 5, new DateTime(2022, 2, 11, 9, 2, 52, 412, DateTimeKind.Local).AddTicks(1081), "6ca24cbc-8085-475b-8bee-b3c09575561e", "cc033eab-8a7e-4c70-8a87-1aee071141a4" },
                    { 3, 7, new DateTime(2022, 2, 15, 9, 2, 52, 413, DateTimeKind.Local).AddTicks(3321), "40ae9fef-c94e-4823-a4da-bd1686467689", "cc033eab-8a7e-4c70-8a87-1aee071141a4" }
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

            migrationBuilder.AddForeignKey(
                name: "FK_UserSpecialties_Users_UserId",
                table: "UserSpecialties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
