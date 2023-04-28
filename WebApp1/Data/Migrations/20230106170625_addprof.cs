using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class addprof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfesorId",
                table: "Curs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curs_ProfesorId",
                table: "Curs",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curs_AspNetUsers_ProfesorId",
                table: "Curs",
                column: "ProfesorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curs_AspNetUsers_ProfesorId",
                table: "Curs");

            migrationBuilder.DropIndex(
                name: "IX_Curs_ProfesorId",
                table: "Curs");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Curs");
        }
    }
}
