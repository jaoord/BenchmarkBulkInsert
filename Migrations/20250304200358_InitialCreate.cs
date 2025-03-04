using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenchmarkBulkInsert.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Metars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Station = table.Column<string>(type: "TEXT", nullable: true),
                    RawData = table.Column<string>(type: "TEXT", nullable: true),
                    LastChange = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetarsWithUniqueConstraint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Station = table.Column<string>(type: "TEXT", nullable: true),
                    RawData = table.Column<string>(type: "TEXT", nullable: true),
                    LastChange = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetarsWithUniqueConstraint", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MetarsWithUniqueConstraint_Station_LastChange",
                table: "MetarsWithUniqueConstraint",
                columns: new[] { "Station", "LastChange" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Metars");

            migrationBuilder.DropTable(
                name: "MetarsWithUniqueConstraint");
        }
    }
}
