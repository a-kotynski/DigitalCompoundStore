using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalCompoundStoreAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class facility_bought_and_sold_adjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Facilities_AddressId",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "FacilityBoughtId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FacilitySoldId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Facilities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FacilityId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FacilityId",
                table: "Products",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PriceId",
                table: "Products",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PriceUsedId",
                table: "Products",
                column: "PriceUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VideoGameId",
                table: "Products",
                column: "VideoGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_AddressId",
                table: "Facilities",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Facilities_FacilityId",
                table: "Products",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PricesUsed_PriceUsedId",
                table: "Products",
                column: "PriceUsedId",
                principalTable: "PricesUsed",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Prices_PriceId",
                table: "Products",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VideoGames_VideoGameId",
                table: "Products",
                column: "VideoGameId",
                principalTable: "VideoGames",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Facilities_FacilityId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PricesUsed_PriceUsedId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Prices_PriceId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_VideoGames_VideoGameId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FacilityId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PriceId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PriceUsedId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VideoGameId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_AddressId",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "FacilityId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacilityBoughtId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacilitySoldId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Facilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_AddressId",
                table: "Facilities",
                column: "AddressId",
                unique: true);
        }
    }
}
