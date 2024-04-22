using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductBackend.Migrations
{
    /// <inheritdoc />
    public partial class locationnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_SuperMarkets_Locations_LocationId",
                table: "SuperMarkets");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperMarkets_Locations_LocationId",
                table: "SuperMarkets",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "locationId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
            name: "FK_SuperMarkets_Locations_LocationId",
            table: "SuperMarkets");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperMarkets_Locations_LocationId",
                table: "SuperMarkets",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "locationId",
                onDelete: ReferentialAction.Cascade);

        }
    }
}
