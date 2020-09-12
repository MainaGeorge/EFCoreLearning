using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreBasics.DataAccess.Migrations
{
    public partial class AddingProducingCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProducingCompanyId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProducingCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducingCompany", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducingCompanyId",
                table: "Movies",
                column: "ProducingCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_ProducingCompany_ProducingCompanyId",
                table: "Movies",
                column: "ProducingCompanyId",
                principalTable: "ProducingCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_ProducingCompany_ProducingCompanyId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "ProducingCompany");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducingCompanyId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ProducingCompanyId",
                table: "Movies");
        }
    }
}
