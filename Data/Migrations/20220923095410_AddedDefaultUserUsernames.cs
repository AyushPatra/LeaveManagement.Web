using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                column: "ConcurrencyStamp",
                value: "0f7cc6b1-ba76-4821-a3d9-878987d97b49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                column: "ConcurrencyStamp",
                value: "924b1e05-30ab-4547-a8ec-c2e0ffe9cb1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a6c8fde9-5907-471a-8f36-199490526e58", true, "PATRA@GMAIL.COM", "AQAAAAEAACcQAAAAEG7adSH3IWWpR7HUdIeK14F+947kf9cokkr9a2/CkQZ/2RZ1gNiN+7XM2Q6Ua4qb0A==", "75899926-c8d1-487c-8fad-38872fcda3e8", "patra@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2076d869-f328-48c6-9268-1ff0e6125792", true, "AYUSH@GMAIL.COM", "AQAAAAEAACcQAAAAEMFtR50thOdIsjsARKDHCpJ7N4w5ktpBwNFDSw3GA/wJqI8sYaXOlLEnHq0YORGCcg==", "469eb2d3-5ba8-4aae-abd5-5a9ae8344dc0", "ayush@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                column: "ConcurrencyStamp",
                value: "d1289e3d-e0a3-4457-b171-b20261967189");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                column: "ConcurrencyStamp",
                value: "facaf1d4-f41f-4233-980a-1794af15e92b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ffb74366-15d8-4258-84b8-a44edb611b3f", false, null, "AQAAAAEAACcQAAAAEC26sjvvuUu5QK9AMz+lzA2yuD3KH7obHYXzNW6TvHMxg4kz2xVgMd2IbQdbyTtWNw==", "528d3b2c-d301-4e1e-9e3d-63dcc3510478", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2bef3a9b-df77-41c3-bd9c-13d61599d275", false, null, "AQAAAAEAACcQAAAAEE8Z/cJEJlRb5C319uzlQWCUOw2gyXg5qXzZmnrukCpdbD97Rjh97cUGpbneBE4mNg==", "efee2d9c-1c95-4d22-b5ea-26d1a9ada162", null });
        }
    }
}
