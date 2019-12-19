using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_12_IntroModels.Migrations
{
    public partial class Relationships_between_models_were_created : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Workers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Name);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_CountryName",
                table: "Workers",
                column: "CountryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Countries_CountryName",
                table: "Workers",
                column: "CountryName",
                principalTable: "Countries",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Countries_CountryName",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Workers_CountryName",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Workers");
        }
    }
}
