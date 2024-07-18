using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BallotCast.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionResult_ReferendumResult_ReferendumResultId",
                table: "OptionResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Paragraph_Referendums_ReferendumId",
                table: "Paragraph");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferendumOption_Referendums_ReferendumId",
                table: "ReferendumOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferendumResult",
                table: "ReferendumResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferendumOption",
                table: "ReferendumOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paragraph",
                table: "Paragraph");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionResult",
                table: "OptionResult");

            migrationBuilder.RenameTable(
                name: "ReferendumResult",
                newName: "ReferendumResults");

            migrationBuilder.RenameTable(
                name: "ReferendumOption",
                newName: "ReferendumOptions");

            migrationBuilder.RenameTable(
                name: "Paragraph",
                newName: "Paragraphs");

            migrationBuilder.RenameTable(
                name: "OptionResult",
                newName: "OptionResults");

            migrationBuilder.RenameIndex(
                name: "IX_ReferendumOption_ReferendumId",
                table: "ReferendumOptions",
                newName: "IX_ReferendumOptions_ReferendumId");

            migrationBuilder.RenameIndex(
                name: "IX_Paragraph_ReferendumId",
                table: "Paragraphs",
                newName: "IX_Paragraphs_ReferendumId");

            migrationBuilder.RenameIndex(
                name: "IX_OptionResult_ReferendumResultId",
                table: "OptionResults",
                newName: "IX_OptionResults_ReferendumResultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferendumResults",
                table: "ReferendumResults",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferendumOptions",
                table: "ReferendumOptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paragraphs",
                table: "Paragraphs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionResults",
                table: "OptionResults",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ReferendumResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ReferendumResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ReferendumResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ReferendumResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ReferendumResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ReferendumResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResultDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 18, 10, 27, 54, 204, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.AddForeignKey(
                name: "FK_OptionResults_ReferendumResults_ReferendumResultId",
                table: "OptionResults",
                column: "ReferendumResultId",
                principalTable: "ReferendumResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Referendums_ReferendumId",
                table: "Paragraphs",
                column: "ReferendumId",
                principalTable: "Referendums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferendumOptions_Referendums_ReferendumId",
                table: "ReferendumOptions",
                column: "ReferendumId",
                principalTable: "Referendums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referendums_ReferendumResults_ResultId",
                table: "Referendums",
                column: "ResultId",
                principalTable: "ReferendumResults",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OptionResults_ReferendumResults_ReferendumResultId",
                table: "OptionResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Referendums_ReferendumId",
                table: "Paragraphs");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferendumOptions_Referendums_ReferendumId",
                table: "ReferendumOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Referendums_ReferendumResults_ResultId",
                table: "Referendums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferendumResults",
                table: "ReferendumResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReferendumOptions",
                table: "ReferendumOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paragraphs",
                table: "Paragraphs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OptionResults",
                table: "OptionResults");

            migrationBuilder.RenameTable(
                name: "ReferendumResults",
                newName: "ReferendumResult");

            migrationBuilder.RenameTable(
                name: "ReferendumOptions",
                newName: "ReferendumOption");

            migrationBuilder.RenameTable(
                name: "Paragraphs",
                newName: "Paragraph");

            migrationBuilder.RenameTable(
                name: "OptionResults",
                newName: "OptionResult");

            migrationBuilder.RenameIndex(
                name: "IX_ReferendumOptions_ReferendumId",
                table: "ReferendumOption",
                newName: "IX_ReferendumOption_ReferendumId");

            migrationBuilder.RenameIndex(
                name: "IX_Paragraphs_ReferendumId",
                table: "Paragraph",
                newName: "IX_Paragraph_ReferendumId");

            migrationBuilder.RenameIndex(
                name: "IX_OptionResults_ReferendumResultId",
                table: "OptionResult",
                newName: "IX_OptionResult_ReferendumResultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferendumResult",
                table: "ReferendumResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReferendumOption",
                table: "ReferendumOption",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paragraph",
                table: "Paragraph",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OptionResult",
                table: "OptionResult",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraph_Referendums_ReferendumId",
                table: "Paragraph",
                column: "ReferendumId",
                principalTable: "Referendums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferendumOption_Referendums_ReferendumId",
                table: "ReferendumOption",
                column: "ReferendumId",
                principalTable: "Referendums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums",
                column: "ResultId",
                principalTable: "ReferendumResult",
                principalColumn: "Id");
        }
    }
}
