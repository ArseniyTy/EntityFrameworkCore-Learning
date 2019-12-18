using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_12_IntroModels.Migrations
{
    public partial class FluentAPIMethods_were_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Workers",
                newName: "Worker ID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Workers",
                nullable: false,
                defaultValue: 18,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Worker ID",
                table: "Workers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Workers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 18);
        }
    }
}
