using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6164), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6184), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6192), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6609), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6614), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6821), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6825), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6826), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6829), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 11, 18, 12, 35, 31, 210, DateTimeKind.Local).AddTicks(6832), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
