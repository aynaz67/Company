using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 10, 18, 3, 58, 230, DateTimeKind.Local).AddTicks(9392), new DateTime(2025, 4, 10, 17, 3, 58, 230, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 10, 18, 3, 58, 230, DateTimeKind.Local).AddTicks(9454), new DateTime(2025, 4, 10, 17, 3, 58, 230, DateTimeKind.Utc).AddTicks(9453) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roles",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Customer");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 58, 3, 83, DateTimeKind.Local).AddTicks(8314), new DateTime(2025, 4, 10, 14, 58, 3, 83, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 10, 15, 58, 3, 83, DateTimeKind.Local).AddTicks(8384), new DateTime(2025, 4, 10, 14, 58, 3, 83, DateTimeKind.Utc).AddTicks(8382) });
        }
    }
}
