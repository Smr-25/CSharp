using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pa201LabN7.Data.Migrations
{
    /// <inheritdoc />
    public partial class addeventtable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Eve",
                table: "Eve");

            migrationBuilder.RenameTable(
                name: "Eve",
                newName: "Events");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Eve");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eve",
                table: "Eve",
                column: "Id");
        }
    }
}
