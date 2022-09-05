using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace etech_backend.Migrations
{
    public partial class criaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    IdCarrinho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.IdCarrinho);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vendedor = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    IdCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVendedor = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorTotal = table.Column<double>(type: "double", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    IdEmail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnderecoEmail = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.IdEmail);
                    table.ForeignKey(
                        name: "FK_Emails_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Principal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Referencia = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Enderecos_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    IdFavorito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.IdFavorito);
                    table.ForeignKey(
                        name: "FK_Favoritos_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    IdTelefone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ddd = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefones_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<double>(type: "double", nullable: false),
                    QtdEstoque = table.Column<int>(type: "int", nullable: false),
                    Desconto = table.Column<double>(type: "double", nullable: false),
                    FavoritoIdFavorito = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_Produtos_Favoritos_FavoritoIdFavorito",
                        column: x => x.FavoritoIdFavorito,
                        principalTable: "Favoritos",
                        principalColumn: "IdFavorito");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarrinhoProdutos",
                columns: table => new
                {
                    IdCompra = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoProdutos", x => new { x.IdCompra, x.IdProduto });
                    table.ForeignKey(
                        name: "FK_CarrinhoProdutos_Compras_IdCompra",
                        column: x => x.IdCompra,
                        principalTable: "Compras",
                        principalColumn: "IdCompra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoProdutos_Produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompraProdutos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    IdCompra = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraProdutos", x => new { x.IdCompra, x.IdProduto });
                    table.ForeignKey(
                        name: "FK_CompraProdutos_Compras_IdCompra",
                        column: x => x.IdCompra,
                        principalTable: "Compras",
                        principalColumn: "IdCompra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraProdutos_Produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProdutos_IdProduto",
                table: "CarrinhoProdutos",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_CompraProdutos_IdProduto",
                table: "CompraProdutos",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioIdUsuario",
                table: "Compras",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UsuarioIdUsuario",
                table: "Emails",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_UsuarioIdUsuario",
                table: "Enderecos",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_UsuarioIdUsuario",
                table: "Favoritos",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FavoritoIdFavorito",
                table: "Produtos",
                column: "FavoritoIdFavorito");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_UsuarioIdUsuario",
                table: "Telefones",
                column: "UsuarioIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoProdutos");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "CompraProdutos");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
