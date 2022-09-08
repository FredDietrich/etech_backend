using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etech_backend.Migrations
{
    public partial class updateBanco3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoProdutos_Compras_IdCompra",
                table: "CarrinhoProdutos");

            migrationBuilder.RenameColumn(
                name: "IdCompra",
                table: "CarrinhoProdutos",
                newName: "IdCarrinho");

            migrationBuilder.AddColumn<int>(
                name: "CompraIdCompra",
                table: "CarrinhoProdutos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProdutos_CompraIdCompra",
                table: "CarrinhoProdutos",
                column: "CompraIdCompra");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoProdutos_Carrinhos_IdCarrinho",
                table: "CarrinhoProdutos",
                column: "IdCarrinho",
                principalTable: "Carrinhos",
                principalColumn: "IdCarrinho",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoProdutos_Compras_CompraIdCompra",
                table: "CarrinhoProdutos",
                column: "CompraIdCompra",
                principalTable: "Compras",
                principalColumn: "IdCompra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoProdutos_Carrinhos_IdCarrinho",
                table: "CarrinhoProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoProdutos_Compras_CompraIdCompra",
                table: "CarrinhoProdutos");

            migrationBuilder.DropIndex(
                name: "IX_CarrinhoProdutos_CompraIdCompra",
                table: "CarrinhoProdutos");

            migrationBuilder.DropColumn(
                name: "CompraIdCompra",
                table: "CarrinhoProdutos");

            migrationBuilder.RenameColumn(
                name: "IdCarrinho",
                table: "CarrinhoProdutos",
                newName: "IdCompra");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoProdutos_Compras_IdCompra",
                table: "CarrinhoProdutos",
                column: "IdCompra",
                principalTable: "Compras",
                principalColumn: "IdCompra",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
