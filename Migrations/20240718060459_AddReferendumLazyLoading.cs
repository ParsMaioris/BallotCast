using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BallotCast.Migrations
{
    /// <inheritdoc />
    public partial class AddReferendumLazyLoading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionResult_ReferendumResult_ReferendumResultId",
                table: "OptionResult");

            migrationBuilder.AlterColumn<int>(
                name: "ReferendumResultId",
                table: "OptionResult",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.AddForeignKey(
                name: "FK_OptionResult_ReferendumResult_ReferendumResultId",
                table: "OptionResult",
                column: "ReferendumResultId",
                principalTable: "ReferendumResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionResult_ReferendumResult_ReferendumResultId",
                table: "OptionResult");

            migrationBuilder.AlterColumn<int>(
                name: "ReferendumResultId",
                table: "OptionResult",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OptionResult_ReferendumResult_ReferendumResultId",
                table: "OptionResult",
                column: "ReferendumResultId",
                principalTable: "ReferendumResult",
                principalColumn: "Id");
        }
    }
}
