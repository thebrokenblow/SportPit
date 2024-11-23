using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportPit.Migrations
{
    /// <inheritdoc />
    public partial class ChangeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Carts_CartsId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "carts");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "carts",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "DatePurchase",
                table: "carts",
                newName: "date_purchase");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "carts",
                newName: "IX_carts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carts",
                table: "carts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Id",
                table: "products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_carts_Id",
                table: "carts",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_carts_CartsId",
                table: "CartProduct",
                column: "CartsId",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carts_Users_UserId",
                table: "carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_carts_CartsId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_Users_UserId",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_products_Id",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carts",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_Id",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "carts",
                newName: "Carts");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Carts",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "date_purchase",
                table: "Carts",
                newName: "DatePurchase");

            migrationBuilder.RenameIndex(
                name: "IX_carts_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Carts_CartsId",
                table: "CartProduct",
                column: "CartsId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
