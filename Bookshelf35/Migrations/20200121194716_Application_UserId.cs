using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf35.Migrations
{
    public partial class Application_UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_AspNetUsers_ApplicationUserId1",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_ApplicationUserId1",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Author");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Author",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Author_ApplicationUserId",
                table: "Author",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_AspNetUsers_ApplicationUserId",
                table: "Author",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_AspNetUsers_ApplicationUserId",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_ApplicationUserId",
                table: "Author");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Author",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Author",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Author_ApplicationUserId1",
                table: "Author",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_AspNetUsers_ApplicationUserId1",
                table: "Author",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
