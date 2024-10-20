using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Foodera_API.Migrations
{
    /// <inheritdoc />
    public partial class Fooderainit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalQuentity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductPicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorie_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
    name: "Product",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
        Quentity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        Picpath = table.Column<string>(type: "nvarchar(max)", nullable: true),
        IsAvailable = table.Column<bool>(type: "bit", nullable: false),
        categoryID = table.Column<int>(type: "int", nullable: true),
        ordertID = table.Column<int>(type: "int", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Product", x => x.Id);
        table.ForeignKey(
            name: "FK_Product_Categorie_categoryID",
            column: x => x.categoryID,
            principalTable: "Categorie",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        table.ForeignKey(
            name: "FK_Product_Order_ordertID",
            column: x => x.ordertID,
            principalTable: "Order",
            principalColumn: "Id",
            onDelete: ReferentialAction.NoAction);  // Change to NoAction
    });


            migrationBuilder.CreateIndex(
                name: "IX_Categorie_orderId",
                table: "Categorie",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ordertID",
                table: "Product",
                column: "ordertID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
