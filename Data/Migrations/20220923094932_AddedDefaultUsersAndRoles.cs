using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d1df689-b74c-532c-7337-0eb4256fb6e5", "d1289e3d-e0a3-4457-b171-b20261967189", "User", "USER" },
                    { "3d1df689-b82c-486a-8280-0eb4256fa9e5", "facaf1d4-f41f-4233-980a-1794af15e92b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "33d1df689-a82c-486a-8280-0eb4256fa9e6", 0, "ffb74366-15d8-4258-84b8-a44edb611b3f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "patra@gmail.com", false, "Ayush", "Patra", false, null, "PATRA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEC26sjvvuUu5QK9AMz+lzA2yuD3KH7obHYXzNW6TvHMxg4kz2xVgMd2IbQdbyTtWNw==", null, false, "528d3b2c-d301-4e1e-9e3d-63dcc3510478", null, false, null },
                    { "997f9f48-fa38-421b-947e-bee5092d1ae7", 0, "2bef3a9b-df77-41c3-bd9c-13d61599d275", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayush@gmail.com", false, "Ayush", "Patra", false, null, "AYUSH@GMAIL.COM", null, "AQAAAAEAACcQAAAAEE8Z/cJEJlRb5C319uzlQWCUOw2gyXg5qXzZmnrukCpdbD97Rjh97cUGpbneBE4mNg==", null, false, "efee2d9c-1c95-4d22-b5ea-26d1a9ada162", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d1df689-b82c-486a-8280-0eb4256fa9e5", "33d1df689-a82c-486a-8280-0eb4256fa9e6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d1df689-b74c-532c-7337-0eb4256fb6e5", "997f9f48-fa38-421b-947e-bee5092d1ae7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d1df689-b82c-486a-8280-0eb4256fa9e5", "33d1df689-a82c-486a-8280-0eb4256fa9e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d1df689-b74c-532c-7337-0eb4256fb6e5", "997f9f48-fa38-421b-947e-bee5092d1ae7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7");
        }
    }
}
