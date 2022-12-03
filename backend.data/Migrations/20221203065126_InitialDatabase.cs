using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkInstructionSets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkInstructionSets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    InstructionSummary = table.Column<string>(type: "text", nullable: false),
                    WorkInstructionSetID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructions_WorkInstructionSets_WorkInstructionSetID",
                        column: x => x.WorkInstructionSetID,
                        principalTable: "WorkInstructionSets",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_WorkInstructionSetID",
                table: "Instructions",
                column: "WorkInstructionSetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "WorkInstructionSets");
        }
    }
}
