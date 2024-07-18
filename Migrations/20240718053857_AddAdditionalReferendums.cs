using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BallotCast.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalReferendums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraph_Referendums_ReferendumId",
                table: "Paragraph");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferendumOption_Referendums_ReferendumId",
                table: "ReferendumOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums");

            migrationBuilder.AlterColumn<int>(
                name: "ResultId",
                table: "Referendums",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ReferendumId",
                table: "ReferendumOption",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReferendumId",
                table: "Paragraph",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ReferendumResult",
                columns: new[] { "Id", "ResultDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890) },
                    { 2, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890) },
                    { 3, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890) },
                    { 4, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890) },
                    { 5, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890) },
                    { 6, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6890) }
                });

            migrationBuilder.InsertData(
                table: "Referendums",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Question", "ResultId", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6970), null, "Do you support the new environmental policy to reduce carbon emissions by 40% by 2030?", 1, 1, "Environmental Policy" },
                    { 2, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980), null, "Do you support the new education reform to introduce coding classes in all high schools?", 2, 0, "Education Reform" },
                    { 3, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980), null, "Do you support the proposed improvements to the healthcare system to provide free healthcare to all citizens?", 3, 1, "Healthcare Improvement" },
                    { 4, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980), null, "Do you support the plan to develop new public transport infrastructure, including new bus and train routes?", 4, 0, "Transport Infrastructure" },
                    { 5, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980), null, "Do you support the proposed tax reform to reduce income tax rates for middle-class families?", 5, 0, "Tax Reform" },
                    { 6, new DateTime(2024, 7, 18, 5, 38, 57, 598, DateTimeKind.Utc).AddTicks(6980), null, "Do you support the initiative to increase investment in renewable energy sources such as solar and wind power?", 6, 1, "Renewable Energy" }
                });

            migrationBuilder.InsertData(
                table: "Paragraph",
                columns: new[] { "Id", "Content", "ReferendumId" },
                values: new object[,]
                {
                    { 1, "This policy aims to address climate change by reducing carbon emissions.", 1 },
                    { 2, "The policy includes measures such as promoting renewable energy sources.", 1 },
                    { 3, "The reform aims to equip students with essential skills for the future job market.", 2 },
                    { 4, "Coding classes will be mandatory for all high school students.", 2 },
                    { 5, "The healthcare improvements include free healthcare services for all citizens.", 3 },
                    { 6, "The plan includes increasing funding for hospitals and clinics.", 3 },
                    { 7, "The new transport infrastructure plan aims to reduce traffic congestion.", 4 },
                    { 8, "The plan includes new bus and train routes to improve public transport.", 4 },
                    { 9, "The tax reform proposal aims to reduce the tax burden on middle-class families.", 5 },
                    { 10, "The plan includes reducing income tax rates and increasing tax credits.", 5 },
                    { 11, "The initiative aims to increase investment in renewable energy sources.", 6 },
                    { 12, "The plan includes building new solar and wind power plants.", 6 }
                });

            migrationBuilder.InsertData(
                table: "ReferendumOption",
                columns: new[] { "Id", "OptionText", "ReferendumId", "VoteCount" },
                values: new object[,]
                {
                    { 1, "Yes", 1, 0 },
                    { 2, "No", 1, 0 },
                    { 3, "Yes", 2, 0 },
                    { 4, "No", 2, 0 },
                    { 5, "Yes", 3, 0 },
                    { 6, "No", 3, 0 },
                    { 7, "Yes", 4, 0 },
                    { 8, "No", 4, 0 },
                    { 9, "Yes", 5, 0 },
                    { 10, "No", 5, 0 },
                    { 11, "Yes", 6, 0 },
                    { 12, "No", 6, 0 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraph_Referendums_ReferendumId",
                table: "Paragraph");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferendumOption_Referendums_ReferendumId",
                table: "ReferendumOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums");

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Paragraph",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ReferendumOption",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Referendums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReferendumResult",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "ResultId",
                table: "Referendums",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReferendumId",
                table: "ReferendumOption",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ReferendumId",
                table: "Paragraph",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraph_Referendums_ReferendumId",
                table: "Paragraph",
                column: "ReferendumId",
                principalTable: "Referendums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReferendumOption_Referendums_ReferendumId",
                table: "ReferendumOption",
                column: "ReferendumId",
                principalTable: "Referendums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums",
                column: "ResultId",
                principalTable: "ReferendumResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
