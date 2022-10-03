using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                column: "ConcurrencyStamp",
                value: "df3129d7-79dd-4072-b622-160a9f3a0f9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                column: "ConcurrencyStamp",
                value: "fade1486-a4f4-468f-bc88-741d45913068");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4317b631-64ed-4017-bf81-1a65ed9bfe90", "AQAAAAEAACcQAAAAEL/eZCPwR/kyq75yt6oyhj5KfVtCXYnF+pYCbAQdCjrqK3yDlhDyIrDdt/4FfrTQCQ==", "ddcca6ec-215c-4953-97ac-ce4cce9d695c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daa9452e-d224-409f-bccf-20828f11a200", "AQAAAAEAACcQAAAAEKGyHwYL26vHSX/S06iBkcNuGYXl/VtwXaGBoZ95BO/bjRwnAg5GBxhbWwF8W/hZGg==", "f7475f73-ed18-4b2e-be5d-a0c349c90ac3" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
