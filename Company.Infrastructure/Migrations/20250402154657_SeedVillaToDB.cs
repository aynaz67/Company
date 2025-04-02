using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreateDate", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 2, 16, 46, 57, 637, DateTimeKind.Local).AddTicks(4170), "It's me", "Aynaz", null },
                    { 2, new DateTime(2025, 4, 2, 16, 46, 57, 637, DateTimeKind.Local).AddTicks(4276), "It's my sister", "Elnaz", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
