using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Porto.DAL.Migrations
{
    /// <inheritdoc />
    public partial class PortoDbVersion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DelUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Category",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_Category = table.Column<int>(type: "int", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    UnitPriceInStock = table.Column<int>(type: "int", nullable: false),
                    CreUser = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    DelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DelUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_ID_Category",
                        column: x => x.ID_Category,
                        principalTable: "Category",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentID",
                table: "Category",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ID_Category",
                table: "Product",
                column: "ID_Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
