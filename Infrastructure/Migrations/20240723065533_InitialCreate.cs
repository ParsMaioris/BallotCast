using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BallotCast.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referendums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Question = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    ResultId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referendums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paragraphs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ReferendumId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paragraphs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paragraphs_Referendums_ReferendumId",
                        column: x => x.ReferendumId,
                        principalTable: "Referendums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferendumResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferendumId = table.Column<int>(type: "INTEGER", nullable: false),
                    YesCount = table.Column<int>(type: "INTEGER", nullable: false),
                    NoCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ResultDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferendumResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferendumResults_Referendums_ReferendumId",
                        column: x => x.ReferendumId,
                        principalTable: "Referendums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoterReferendums",
                columns: table => new
                {
                    VoterId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReferendumId = table.Column<int>(type: "INTEGER", nullable: false),
                    CanVote = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoterReferendums", x => new { x.VoterId, x.ReferendumId });
                    table.ForeignKey(
                        name: "FK_VoterReferendums_Referendums_ReferendumId",
                        column: x => x.ReferendumId,
                        principalTable: "Referendums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoterReferendums_Voters_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Voters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VoterId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReferendumId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsYes = table.Column<bool>(type: "INTEGER", nullable: false),
                    VoteDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_Referendums_ReferendumId",
                        column: x => x.ReferendumId,
                        principalTable: "Referendums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Voters_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Voters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_ReferendumId",
                table: "Paragraphs",
                column: "ReferendumId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferendumResults_ReferendumId",
                table: "ReferendumResults",
                column: "ReferendumId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoterReferendums_ReferendumId",
                table: "VoterReferendums",
                column: "ReferendumId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ReferendumId",
                table: "Votes",
                column: "ReferendumId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paragraphs");

            migrationBuilder.DropTable(
                name: "ReferendumResults");

            migrationBuilder.DropTable(
                name: "VoterReferendums");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Referendums");

            migrationBuilder.DropTable(
                name: "Voters");
        }
    }
}
