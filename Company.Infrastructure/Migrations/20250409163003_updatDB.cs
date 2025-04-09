using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 9, 17, 30, 3, 474, DateTimeKind.Local).AddTicks(4443), new DateTime(2025, 4, 9, 16, 30, 3, 474, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 9, 17, 30, 3, 474, DateTimeKind.Local).AddTicks(4502), new DateTime(2025, 4, 9, 16, 30, 3, 474, DateTimeKind.Utc).AddTicks(4501) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
