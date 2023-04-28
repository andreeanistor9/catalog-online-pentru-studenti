using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class addprofh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Curs_CursId",
                table: "Nota");

            migrationBuilder.AlterColumn<int>(
                name: "Punctaj",
                table: "Nota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CursId",
                table: "Nota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Curs_CursId",
                table: "Nota",
                column: "CursId",
                principalTable: "Curs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Curs_CursId",
                table: "Nota");

            migrationBuilder.AlterColumn<int>(
                name: "Punctaj",
                table: "Nota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CursId",
                table: "Nota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Curs_CursId",
                table: "Nota",
                column: "CursId",
                principalTable: "Curs",
                principalColumn: "Id");
        }
    }
}
