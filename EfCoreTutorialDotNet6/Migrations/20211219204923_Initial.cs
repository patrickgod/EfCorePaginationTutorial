using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTutorialDotNet6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, "Ready Player One" },
                    { 3, "1984" },
                    { 4, "The Matrix Resurrections" },
                    { 5, "Diablo 2: Resurrected" },
                    { 6, "Super Nintendo Entertainment System" },
                    { 7, "Day of the Tentacle" },
                    { 8, "Back to the Future" },
                    { 9, "Toy Story" },
                    { 10, "Brave New World" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
