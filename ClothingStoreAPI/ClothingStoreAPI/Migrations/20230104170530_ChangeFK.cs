using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingStoreAPI.Migrations
{
    public partial class ChangeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Clothes_ClothesId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ClothesId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ClothesId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Clothes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_CategoryId",
                table: "Clothes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Categories_CategoryId",
                table: "Clothes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Categories_CategoryId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_CategoryId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Clothes");

            migrationBuilder.AddColumn<int>(
                name: "ClothesId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ClothesId",
                table: "Categories",
                column: "ClothesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Clothes_ClothesId",
                table: "Categories",
                column: "ClothesId",
                principalTable: "Clothes",
                principalColumn: "Id");
        }
    }
}
