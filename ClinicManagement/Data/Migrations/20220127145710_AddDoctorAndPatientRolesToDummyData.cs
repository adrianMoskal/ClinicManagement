using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddDoctorAndPatientRolesToDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "65c225e1-5e1e-48fa-b8ab-9dd8794b9043", "Person who is giving medical care", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "d428231e-4f51-4e41-913e-056f91346c16", "59b3eba1-eaac-442f-9ca1-a2b5a3a8e287", "Person who is receiving medical care", "Patient", "PATIENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "526fa4c0-f544-4ad0-9d31-0185533cdf48");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d428231e-4f51-4e41-913e-056f91346c16");
        }
    }
}
