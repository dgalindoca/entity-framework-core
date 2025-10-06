using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class renameDisplayColumnInGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Display",
                table: "Genres",
                newName: "DisplayOrder");

            // previous .NET versions did not have the 'RenameColumn' method.
            //migrationBuilder.Sql("UPDATE dbo.genres SET Display=DisplayOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Genres",
                newName: "Display");
        }
    }
}
