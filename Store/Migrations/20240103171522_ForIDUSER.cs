using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Migrations
{
    public partial class ForIDUSER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "identityUserId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_identityUserId",
                table: "Products",
                column: "identityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_identityUserId",
                table: "Products",
                column: "identityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_identityUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_identityUserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "identityUserId",
                table: "Products");
        }
    }
}
