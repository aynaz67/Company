using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EdiConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 10, 4, 53, 252, DateTimeKind.Local).AddTicks(8507), new DateTime(2025, 4, 5, 9, 4, 53, 252, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 10, 4, 53, 252, DateTimeKind.Local).AddTicks(8588), new DateTime(2025, 4, 5, 9, 4, 53, 252, DateTimeKind.Utc).AddTicks(8586) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 9, 54, 1, 992, DateTimeKind.Local).AddTicks(9408), new DateTime(2025, 4, 5, 8, 54, 1, 992, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 9, 54, 1, 992, DateTimeKind.Local).AddTicks(9468), new DateTime(2025, 4, 5, 8, 54, 1, 992, DateTimeKind.Utc).AddTicks(9466) });
        }
    }
}
