using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BallotCast.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReferendumSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 52, 15, 298, DateTimeKind.Utc).AddTicks(2970));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980));
        }
    }
}
