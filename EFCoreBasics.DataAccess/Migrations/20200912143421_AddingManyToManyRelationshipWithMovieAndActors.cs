using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreBasics.DataAccess.Migrations
{
    public partial class AddingManyToManyRelationshipWithMovieAndActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoviesActorsJoiningTable",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesActorsJoiningTable", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MoviesActorsJoiningTable_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesActorsJoiningTable_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesActorsJoiningTable_MovieId",
                table: "MoviesActorsJoiningTable",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesActorsJoiningTable");
        }
    }
}
