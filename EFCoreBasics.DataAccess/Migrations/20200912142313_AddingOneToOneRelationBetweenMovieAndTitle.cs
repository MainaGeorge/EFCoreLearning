using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreBasics.DataAccess.Migrations
{
    public partial class AddingOneToOneRelationBetweenMovieAndTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_TitleId",
                table: "Movies",
                column: "TitleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Titles_TitleId",
                table: "Movies",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Titles_TitleId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_TitleId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Movies");
        }
    }
}
