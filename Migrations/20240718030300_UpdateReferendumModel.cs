using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BallotCast.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReferendumModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vote",
                table: "Referendums",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Referendums",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Referendums",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "Referendums",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Referendums",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Paragraph",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ReferendumId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paragraph", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paragraph_Referendums_ReferendumId",
                        column: x => x.ReferendumId,
                        principalTable: "Referendums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReferendumOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OptionText = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    VoteCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ReferendumId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferendumOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferendumOption_Referendums_ReferendumId",
                        column: x => x.ReferendumId,
                        principalTable: "Referendums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReferendumResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResultDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferendumResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OptionResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OptionText = table.Column<string>(type: "TEXT", nullable: false),
                    VoteCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ReferendumResultId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionResult_ReferendumResult_ReferendumResultId",
                        column: x => x.ReferendumResultId,
                        principalTable: "ReferendumResult",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referendums_ResultId",
                table: "Referendums",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionResult_ReferendumResultId",
                table: "OptionResult",
                column: "ReferendumResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Paragraph_ReferendumId",
                table: "Paragraph",
                column: "ReferendumId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferendumOption_ReferendumId",
                table: "ReferendumOption",
                column: "ReferendumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums",
                column: "ResultId",
                principalTable: "ReferendumResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referendums_ReferendumResult_ResultId",
                table: "Referendums");

            migrationBuilder.DropTable(
                name: "OptionResult");

            migrationBuilder.DropTable(
                name: "Paragraph");

            migrationBuilder.DropTable(
                name: "ReferendumOption");

            migrationBuilder.DropTable(
                name: "ReferendumResult");

            migrationBuilder.DropIndex(
                name: "IX_Referendums_ResultId",
                table: "Referendums");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Referendums");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Referendums");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "Referendums");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Referendums");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Referendums",
                newName: "Vote");
        }
    }
}
