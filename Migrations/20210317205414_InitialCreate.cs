using Microsoft.EntityFrameworkCore.Migrations;

namespace BonFromage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ShortDescription = table.Column<string>(type: "TEXT", nullable: false),
                    LongDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    SellingPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProductionPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");
        }
    }
}
