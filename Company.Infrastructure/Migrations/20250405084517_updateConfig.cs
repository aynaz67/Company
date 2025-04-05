using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Villa",
                table: "Villa");

            migrationBuilder.RenameTable(
                name: "Villa",
                newName: "Villas");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Villas",
                newName: "Villa Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Villas",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Villas",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villas",
                table: "Villas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 9, 45, 16, 974, DateTimeKind.Local).AddTicks(1077), new DateTime(2025, 4, 5, 8, 45, 16, 974, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 9, 45, 16, 974, DateTimeKind.Local).AddTicks(1138), new DateTime(2025, 4, 5, 8, 45, 16, 974, DateTimeKind.Utc).AddTicks(1136) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Villas",
                table: "Villas");

            migrationBuilder.RenameTable(
                name: "Villas",
                newName: "Villa");

            migrationBuilder.RenameColumn(
                name: "Villa Name",
                table: "Villa",
                newName: "Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Villa",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Villa",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Villa",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villa",
                table: "Villa",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 8, 12, 54, 184, DateTimeKind.Local).AddTicks(5540), null });

            migrationBuilder.UpdateData(
                table: "Villa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 8, 12, 54, 184, DateTimeKind.Local).AddTicks(5602), null });
        }
    }
}
