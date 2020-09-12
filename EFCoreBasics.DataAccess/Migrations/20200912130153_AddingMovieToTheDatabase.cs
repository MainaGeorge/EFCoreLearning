using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreBasics.DataAccess.Migrations
{
    public partial class AddingMovieToTheDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateReleased = table.Column<DateTime>(nullable: false),
                    BudgetAllocated = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    ActualBudget = table.Column<decimal>(type: "decimal(9, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
