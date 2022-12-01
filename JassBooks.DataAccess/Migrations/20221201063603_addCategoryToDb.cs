using Microsoft.EntityFrameworkCore.Migrations;

namespace JassBooks.DataAccess.Migrations
{
    public partial class addCategoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Covers_CoverId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CoverId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CoverId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CoverTypeId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products",
                column: "CoverTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Covers_CoverTypeId",
                table: "Products",
                column: "CoverTypeId",
                principalTable: "Covers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Covers_CoverTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CoverTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CoverId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverId",
                table: "Products",
                column: "CoverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Covers_CoverId",
                table: "Products",
                column: "CoverId",
                principalTable: "Covers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
