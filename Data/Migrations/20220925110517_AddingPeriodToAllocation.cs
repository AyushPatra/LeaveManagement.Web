using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                column: "ConcurrencyStamp",
                value: "df5e1330-acd5-46be-b637-5ad396bb15a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                column: "ConcurrencyStamp",
                value: "c51c0034-fb09-473a-9f42-188881250acc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f69227dc-c203-42de-a852-177ac04ef5a4", "AQAAAAEAACcQAAAAEDOP06Dzdn+FuRWVY/fT1nMeuXfy8KLwTaagc0ULpeMoZcJsfYI5SHYa9IBBod3tow==", "e05f9e78-6944-4e43-a07b-731f18da7859" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a19afde-3764-4fe5-bbd7-895c5713f282", "AQAAAAEAACcQAAAAEC4CG6m4FmHzq6vsukvOOXd06zX/L1mQmwLttIv2L20vWoYAsxhOLxnRIxEL63zrfw==", "21bbfe79-7a49-4663-aec3-5a3febf87ccc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c8fde9-5907-471a-8f36-199490526e58", "AQAAAAEAACcQAAAAEG7adSH3IWWpR7HUdIeK14F+947kf9cokkr9a2/CkQZ/2RZ1gNiN+7XM2Q6Ua4qb0A==", "75899926-c8d1-487c-8fad-38872fcda3e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2076d869-f328-48c6-9268-1ff0e6125792", "AQAAAAEAACcQAAAAEMFtR50thOdIsjsARKDHCpJ7N4w5ktpBwNFDSw3GA/wJqI8sYaXOlLEnHq0YORGCcg==", "469eb2d3-5ba8-4aae-abd5-5a9ae8344dc0" });
        }
    }
}
