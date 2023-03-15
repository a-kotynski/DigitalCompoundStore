using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalCompoundStoreAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class CommentedOutEverythingRelatedToEnumProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoGamePlatform",
                table: "VideoGames");

            migrationBuilder.DropColumn(
                name: "FacilityType",
                table: "Facilities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoGamePlatform",
                table: "VideoGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilityType",
                table: "Facilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
