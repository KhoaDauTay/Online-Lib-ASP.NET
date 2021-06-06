using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineLibWeb.Data.Migrations
{
    public partial class CreateChapter02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Documents_DocumentId",
                table: "Chapters");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Documents_DocumentId",
                table: "Chapters",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Documents_DocumentId",
                table: "Chapters");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Chapters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Documents_DocumentId",
                table: "Chapters",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
