using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Zespolowy.Migrations
{
    /// <inheritdoc />
    public partial class adw2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinions_Users_UserId",
                table: "Opinions");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Opinions",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinions_Users_UserId",
                table: "Opinions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinions_Users_UserId",
                table: "Opinions");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Users",
                type: "REAL",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Opinions",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinions_Users_UserId",
                table: "Opinions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
