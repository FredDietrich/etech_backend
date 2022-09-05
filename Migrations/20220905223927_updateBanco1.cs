using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etech_backend.Migrations
{
    public partial class updateBanco1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Favoritos_FavoritoIdFavorito",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FavoritoIdFavorito",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FavoritoIdFavorito",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoIdProduto",
                table: "Favoritos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_ProdutoIdProduto",
                table: "Favoritos",
                column: "ProdutoIdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoritos_Produtos_ProdutoIdProduto",
                table: "Favoritos",
                column: "ProdutoIdProduto",
                principalTable: "Produtos",
                principalColumn: "IdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoritos_Produtos_ProdutoIdProduto",
                table: "Favoritos");

            migrationBuilder.DropIndex(
                name: "IX_Favoritos_ProdutoIdProduto",
                table: "Favoritos");

            migrationBuilder.DropColumn(
                name: "ProdutoIdProduto",
                table: "Favoritos");

            migrationBuilder.AddColumn<int>(
                name: "FavoritoIdFavorito",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FavoritoIdFavorito",
                table: "Produtos",
                column: "FavoritoIdFavorito");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Favoritos_FavoritoIdFavorito",
                table: "Produtos",
                column: "FavoritoIdFavorito",
                principalTable: "Favoritos",
                principalColumn: "IdFavorito");
        }
    }
}
