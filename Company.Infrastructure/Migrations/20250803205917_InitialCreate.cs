using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 8, 3, 21, 59, 17, 491, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 8, 3, 20, 59, 17, 491, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 8, 3, 21, 59, 17, 491, DateTimeKind.Local).AddTicks(928), new DateTime(2025, 8, 3, 20, 59, 17, 491, DateTimeKind.Utc).AddTicks(926) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 10, 18, 6, 44, 467, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 4, 10, 17, 6, 44, 467, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 10, 18, 6, 44, 467, DateTimeKind.Local).AddTicks(7612), new DateTime(2025, 4, 10, 17, 6, 44, 467, DateTimeKind.Utc).AddTicks(7610) });
        }
    }
}
