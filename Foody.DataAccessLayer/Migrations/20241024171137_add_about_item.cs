using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foody.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_about_item : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutItems",
                columns: table => new
                {
                    AboutItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutItems", x => x.AboutItemID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutItems");
        }
    }
}
