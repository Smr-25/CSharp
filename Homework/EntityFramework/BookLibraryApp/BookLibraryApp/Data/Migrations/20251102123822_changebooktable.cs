using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class changebooktable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Books",
                newName: "StockCount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockCount",
                table: "Books",
                newName: "Count");
        }
    }
}
