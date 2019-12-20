using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_12_IntroModels.Migrations.Thing
{
    public partial class ManyToMany_relationsip_was_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    SerialNum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Mass = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.SerialNum);
                });

            migrationBuilder.CreateTable(
                name: "Substances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubstanceElement",
                columns: table => new
                {
                    SubstanceId = table.Column<int>(nullable: false),
                    ElementSerialNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstanceElement", x => new { x.SubstanceId, x.ElementSerialNum });
                    table.ForeignKey(
                        name: "FK_SubstanceElement_Elements_ElementSerialNum",
                        column: x => x.ElementSerialNum,
                        principalTable: "Elements",
                        principalColumn: "SerialNum",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubstanceElement_Substances_SubstanceId",
                        column: x => x.SubstanceId,
                        principalTable: "Substances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubstanceElement_ElementSerialNum",
                table: "SubstanceElement",
                column: "ElementSerialNum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubstanceElement");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Substances");
        }
    }
}
