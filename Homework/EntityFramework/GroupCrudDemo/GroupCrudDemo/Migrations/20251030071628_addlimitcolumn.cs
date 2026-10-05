using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrmEfProject.Migrations
{
    /// <inheritdoc />
    public partial class addlimitcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Limit",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Limit",
                table: "Groups");
        }
    }
}
