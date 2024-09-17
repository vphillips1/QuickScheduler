using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickSchedulerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedOnConfiguring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 9, 15, 22, 11, 9, 613, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 9, 15, 22, 11, 9, 613, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 9, 15, 22, 11, 9, 613, DateTimeKind.Local).AddTicks(8115));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 9, 15, 22, 6, 26, 669, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 9, 15, 22, 6, 26, 670, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "AppointmentEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 9, 15, 22, 6, 26, 670, DateTimeKind.Local).AddTicks(94));
        }
    }
}
