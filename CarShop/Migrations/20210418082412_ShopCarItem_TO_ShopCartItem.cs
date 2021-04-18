using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop.Migrations
{
    public partial class ShopCarItem_TO_ShopCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCarItemDb");

            migrationBuilder.CreateTable(
                name: "ShopCartItemDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarItemId = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ShopCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItemDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItemDb_CarDb_CarItemId",
                        column: x => x.CarItemId,
                        principalTable: "CarDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItemDb_CarItemId",
                table: "ShopCartItemDb",
                column: "CarItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItemDb");

            migrationBuilder.CreateTable(
                name: "ShopCarItemDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarItemId = table.Column<int>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ShopCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCarItemDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCarItemDb_CarDb_CarItemId",
                        column: x => x.CarItemId,
                        principalTable: "CarDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCarItemDb_CarItemId",
                table: "ShopCarItemDb",
                column: "CarItemId");
        }
    }
}
