using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class FormattingLeaveAllocationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "LeaveAllocations");

            migrationBuilder.RenameColumn(
                name: "LeaveId",
                table: "LeaveAllocations",
                newName: "NumberOfDays");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                column: "ConcurrencyStamp",
                value: "f7bc3c3b-5742-4150-a3f7-91747ace1437");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                column: "ConcurrencyStamp",
                value: "c8c45cfb-e039-4798-9954-e0bf092383d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "966be9e0-71e2-4c54-9634-21c38a7e8cdf", "AQAAAAEAACcQAAAAEBZXqOwqmoPHvbGL12DMa2QyVP8Kp9LXgi3+QBjhok3HU7qbsT78Qeb/6muTgF5QYg==", "633b8353-37d3-4056-83c8-a4753f9126a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df1ab97e-f9a4-4ca1-99fd-b5cc78e0023d", "AQAAAAEAACcQAAAAEJBrMIat3i3mb0HybiZ+kbXGBT5vuJktUhwxmp0Ydkh8BThA2whXOUBrXypayyjQDA==", "2bd94aec-2640-4856-bbd3-0b64a177ee13" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                newName: "LeaveId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
