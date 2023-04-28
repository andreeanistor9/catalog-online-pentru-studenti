using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class addprofffg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curs_AspNetUsers_ProfesorId",
                table: "Curs");

            migrationBuilder.AlterColumn<string>(
                name: "ProfesorId",
                table: "Curs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Curs_AspNetUsers_ProfesorId",
                table: "Curs",
                column: "ProfesorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curs_AspNetUsers_ProfesorId",
                table: "Curs");

            migrationBuilder.AlterColumn<string>(
                name: "ProfesorId",
                table: "Curs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Curs_AspNetUsers_ProfesorId",
                table: "Curs",
                column: "ProfesorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
