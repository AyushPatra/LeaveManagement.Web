using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                column: "ConcurrencyStamp",
                value: "bef1fe23-1f38-4d99-883f-e7a83d0308b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                column: "ConcurrencyStamp",
                value: "1e178709-0984-45f2-bdbd-d5884a577190");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a926329-44bc-4e50-8438-b0db67b727ed", "AQAAAAEAACcQAAAAEEcdkrfXmW7JAJYcYhsXCaoyA1N+HyjpFkY15mdndglTsOj1qP74rXxPbN/AFRcAOg==", "17a0f752-fed8-4d6e-8dad-c51a4233675b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "997f9f48-fa38-421b-947e-bee5092d1ae7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7dc6dff-95d3-4422-b0aa-fc35d37c0b36", "AQAAAAEAACcQAAAAEPl5j8YO/o7XE9m0YAhATM+LmP9oP2DFvvc94o+vKxDddq+4/zsphyzmHAI2mCKI6Q==", "aee3d774-bd62-4a87-b3ea-283bfd408398" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
