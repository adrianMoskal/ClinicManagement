using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddIdentityDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "accb09ec-6f9f-4c73-a066-f4764d88b278", "All privileges", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2430875-6f50-48b6-97e6-f9c475b602c2", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Adrian", "Moskal", false, null, null, "ADRIANMOSKAL", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", null, false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "adrianMoskal" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "RoleId1", "UserId1" },
                values: new object[] { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "f2430875-6f50-48b6-97e6-f9c475b602c2", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "f2430875-6f50-48b6-97e6-f9c475b602c2" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f2430875-6f50-48b6-97e6-f9c475b602c2");
        }
    }
}
