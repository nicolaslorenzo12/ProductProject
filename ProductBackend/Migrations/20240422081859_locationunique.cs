using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductBackend.Migrations
{
    /// <inheritdoc />
    public partial class locationunique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
            name: "IX_SuperMarkets_LocationId_NotNull",
            table: "SuperMarkets",
            column: "LocationId",
            unique: true,
            filter: "[LocationId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SuperMarkets_LocationId_NotNull",
                table: "SuperMarkets");
        }
    }
}
