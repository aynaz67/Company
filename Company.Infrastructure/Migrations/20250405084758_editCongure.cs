using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editCongure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Villa Name",
                table: "Villas",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 9, 47, 57, 827, DateTimeKind.Local).AddTicks(802), new DateTime(2025, 4, 5, 8, 47, 57, 827, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 5, 9, 47, 57, 827, DateTimeKind.Local).AddTicks(870), new DateTime(2025, 4, 5, 8, 47, 57, 827, DateTimeKind.Utc).AddTicks(869) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Villas",
                newName: "Villa Name");

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
    }
}
