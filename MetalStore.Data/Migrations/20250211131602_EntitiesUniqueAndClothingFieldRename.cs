using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetalStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesUniqueAndClothingFieldRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "ClothingItems",
                newName: "Performer");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PublicUserId",
                table: "Users",
                column: "PublicUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PublicOrderId",
                table: "Orders",
                column: "PublicOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItems_PublicClothingItemId",
                table: "ClothingItems",
                column: "PublicClothingItemId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_PublicUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PublicOrderId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_ClothingItems_PublicClothingItemId",
                table: "ClothingItems");

            migrationBuilder.RenameColumn(
                name: "Performer",
                table: "ClothingItems",
                newName: "Brand");
        }
    }
}
