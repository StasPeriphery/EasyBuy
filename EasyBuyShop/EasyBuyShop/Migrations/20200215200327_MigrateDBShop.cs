using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBuyShop.Migrations
{
    public partial class MigrateDBShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(nullable: true),
                    nameProduct = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    heading = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
