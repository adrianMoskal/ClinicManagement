using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Data.Migrations
{
    public partial class AddDoctorsAndPatientsDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "f2430875-6f50-48b6-97e6-f9c475b602c2" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f2430875-6f50-48b6-97e6-f9c475b602c2");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f93f376e-0543-4073-aaf4-ceb2df8aac0b", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Super", "User", false, null, null, "SUPERUSER", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", "111111111", false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "SuperUser" },
                    { "40ae9fef-c94e-4823-a4da-bd1686467689", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Dean", "Winchester", false, null, null, "DEANWINCHESTER", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", "999888777", false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "deanWinchester" },
                    { "6ca24cbc-8085-475b-8bee-b3c09575561e", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Sam", "Winchester", false, null, null, "SAMWINCHESTER", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", "789456123", false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "samWinchester" },
                    { "80d10f83-f746-4397-a76f-fa2a216833bc", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Castiel", "Clarence", false, null, null, "CASTIELCLARENCE", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", "888567000", false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "castielClarence" },
                    { "cc033eab-8a7e-4c70-8a87-1aee071141a4", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Bobby", "Singer", false, null, null, "BOBBYSINGER", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", "555080911", false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "bobbySinger" },
                    { "0e8f52a7-172d-41ed-bfcc-6214feec8461", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Jody", "Mills", false, null, null, "JODYMILLS", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", "776554112", false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "jodyMills" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "RoleId1", "UserId1" },
                values: new object[,]
                {
                    { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "f93f376e-0543-4073-aaf4-ceb2df8aac0b", null, null },
                    { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "40ae9fef-c94e-4823-a4da-bd1686467689", null, null },
                    { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "6ca24cbc-8085-475b-8bee-b3c09575561e", null, null },
                    { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "80d10f83-f746-4397-a76f-fa2a216833bc", null, null },
                    { "d428231e-4f51-4e41-913e-056f91346c16", "cc033eab-8a7e-4c70-8a87-1aee071141a4", null, null },
                    { "d428231e-4f51-4e41-913e-056f91346c16", "0e8f52a7-172d-41ed-bfcc-6214feec8461", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d428231e-4f51-4e41-913e-056f91346c16", "0e8f52a7-172d-41ed-bfcc-6214feec8461" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "40ae9fef-c94e-4823-a4da-bd1686467689" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "6ca24cbc-8085-475b-8bee-b3c09575561e" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "526fa4c0-f544-4ad0-9d31-0185533cdf48", "80d10f83-f746-4397-a76f-fa2a216833bc" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d428231e-4f51-4e41-913e-056f91346c16", "cc033eab-8a7e-4c70-8a87-1aee071141a4" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "f93f376e-0543-4073-aaf4-ceb2df8aac0b" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0e8f52a7-172d-41ed-bfcc-6214feec8461");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40ae9fef-c94e-4823-a4da-bd1686467689");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6ca24cbc-8085-475b-8bee-b3c09575561e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "80d10f83-f746-4397-a76f-fa2a216833bc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cc033eab-8a7e-4c70-8a87-1aee071141a4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f93f376e-0543-4073-aaf4-ceb2df8aac0b");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2430875-6f50-48b6-97e6-f9c475b602c2", 0, "003c3d02-b420-44f2-960c-02df61764c7a", null, false, "Adrian", "Moskal", false, null, null, "ADRIANMOSKAL", "AQAAAAEAACcQAAAAEFHDs9VsKcDafKl4e7SJYYQpwX/kBoa0wrLRtG9i1aEY92YaINBYp/vN2kwORdKA5w==", null, false, "JTERJVFIKFMJUFEDTFJFHEAJHLKXMBQD", false, "adrianMoskal" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "RoleId1", "UserId1" },
                values: new object[] { "12c114d1-0ad1-4e02-bb85-ec6a2bceed1b", "f2430875-6f50-48b6-97e6-f9c475b602c2", null, null });
        }
    }
}
