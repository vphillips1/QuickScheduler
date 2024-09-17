using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickSchedulerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataAppointmentEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppointmentEntries",
                columns: new[] { "Id", "Created", "Description", "Location", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 22, 6, 26, 669, DateTimeKind.Local).AddTicks(9982), " Meeting regarding promotion", "At V local Cafe", "Meeting with Boss" },
                    { 2, new DateTime(2024, 9, 15, 22, 6, 26, 670, DateTimeKind.Local).AddTicks(91), "Meeting with my daughters teachers", "Bagley Elementary School", "Parent Teacher Conference" },
                    { 3, new DateTime(2024, 9, 15, 22, 6, 26, 670, DateTimeKind.Local).AddTicks(94), "Surprise birthday for Grandma", "My house", "Surprise Birthday" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
