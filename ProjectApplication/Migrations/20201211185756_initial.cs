using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApplication.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_MilkProds_CarId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopFav_MilkProds_carid",
                table: "ShopFav");

            migrationBuilder.DropIndex(
                name: "IX_ShopFav_carid",
                table: "ShopFav");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_CarId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "carid",
                table: "ShopFav");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "OrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "milkid",
                table: "ShopFav",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MilkId",
                table: "OrderDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShopFav_milkid",
                table: "ShopFav",
                column: "milkid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_MilkId",
                table: "OrderDetail",
                column: "MilkId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_MilkProds_MilkId",
                table: "OrderDetail",
                column: "MilkId",
                principalTable: "MilkProds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopFav_MilkProds_milkid",
                table: "ShopFav",
                column: "milkid",
                principalTable: "MilkProds",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_MilkProds_MilkId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopFav_MilkProds_milkid",
                table: "ShopFav");

            migrationBuilder.DropIndex(
                name: "IX_ShopFav_milkid",
                table: "ShopFav");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_MilkId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "milkid",
                table: "ShopFav");

            migrationBuilder.DropColumn(
                name: "MilkId",
                table: "OrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "carid",
                table: "ShopFav",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShopFav_carid",
                table: "ShopFav",
                column: "carid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_CarId",
                table: "OrderDetail",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_MilkProds_CarId",
                table: "OrderDetail",
                column: "CarId",
                principalTable: "MilkProds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopFav_MilkProds_carid",
                table: "ShopFav",
                column: "carid",
                principalTable: "MilkProds",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
