using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class CursNota3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curs_Nota_NotaId",
                table: "Curs");

            migrationBuilder.DropIndex(
                name: "IX_Curs_NotaId",
                table: "Curs");

            migrationBuilder.DropColumn(
                name: "NotaId",
                table: "Curs");

            migrationBuilder.AddColumn<int>(
                name: "CursId",
                table: "Nota",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nota_CursId",
                table: "Nota",
                column: "CursId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Curs_CursId",
                table: "Nota",
                column: "CursId",
                principalTable: "Curs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Curs_CursId",
                table: "Nota");

            migrationBuilder.DropIndex(
                name: "IX_Nota_CursId",
                table: "Nota");

            migrationBuilder.DropColumn(
                name: "CursId",
                table: "Nota");

            migrationBuilder.AddColumn<int>(
                name: "NotaId",
                table: "Curs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Curs_NotaId",
                table: "Curs",
                column: "NotaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curs_Nota_NotaId",
                table: "Curs",
                column: "NotaId",
                principalTable: "Nota",
                principalColumn: "NotaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
