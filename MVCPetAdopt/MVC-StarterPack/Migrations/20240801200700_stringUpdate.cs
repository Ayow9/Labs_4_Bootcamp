using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_StarterPack.Migrations
{
    /// <inheritdoc />
    public partial class stringUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Animals",
                newName: "Breed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "Animals",
                newName: "Description");
        }
    }
}
