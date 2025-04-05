using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationEditConfigure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
