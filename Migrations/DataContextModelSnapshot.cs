﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace etech_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Etech.Entidades.Carrinho", b =>
                {
                    b.Property<int>("IdCarrinho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("IdCarrinho");

                    b.ToTable("Carrinhos");
                });

            modelBuilder.Entity("Etech.Entidades.CarrinhoProduto", b =>
                {
                    b.Property<int>("IdCarrinho")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int?>("CompraIdCompra")
                        .HasColumnType("int");

                    b.Property<double>("Quantidade")
                        .HasColumnType("double");

                    b.HasKey("IdCarrinho", "IdProduto");

                    b.HasIndex("CompraIdCompra");

                    b.HasIndex("IdProduto");

                    b.ToTable("CarrinhoProdutos");
                });

            modelBuilder.Entity("Etech.Entidades.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Etech.Entidades.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("IdCompra");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Etech.Entidades.CompraProduto", b =>
                {
                    b.Property<int>("IdCompra")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<double>("Quantidade")
                        .HasColumnType("double");

                    b.HasKey("IdCompra", "IdProduto");

                    b.HasIndex("IdProduto");

                    b.ToTable("CompraProdutos");
                });

            modelBuilder.Entity("Etech.Entidades.Email", b =>
                {
                    b.Property<int>("IdEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EnderecoEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdEmail");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Etech.Entidades.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<bool>("Principal")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Referencia")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Uf")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdEndereco");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Etech.Entidades.Favorito", b =>
                {
                    b.Property<int>("IdFavorito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoIdProduto")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdFavorito");

                    b.HasIndex("ProdutoIdProduto");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Favoritos");
                });

            modelBuilder.Entity("Etech.Entidades.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Desconto")
                        .HasColumnType("double");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Etech.Entidades.Telefone", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ddd")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdTelefone");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Etech.Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("Vendedor")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Etech.Entidades.CarrinhoProduto", b =>
                {
                    b.HasOne("Etech.Entidades.Compra", null)
                        .WithMany("ProdutosCarrinho")
                        .HasForeignKey("CompraIdCompra");

                    b.HasOne("Etech.Entidades.Carrinho", "Carrinho")
                        .WithMany("ProdutosCarrinho")
                        .HasForeignKey("IdCarrinho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Etech.Entidades.Produto", "Produto")
                        .WithMany("ProdutosCarrinho")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrinho");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Etech.Entidades.Compra", b =>
                {
                    b.HasOne("Etech.Entidades.Usuario", null)
                        .WithMany("Compras")
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("Etech.Entidades.CompraProduto", b =>
                {
                    b.HasOne("Etech.Entidades.Compra", "Compra")
                        .WithMany("ProdutosCompra")
                        .HasForeignKey("IdCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Etech.Entidades.Produto", "Produto")
                        .WithMany("ProdutosCompra")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Etech.Entidades.Email", b =>
                {
                    b.HasOne("Etech.Entidades.Usuario", null)
                        .WithMany("Emails")
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("Etech.Entidades.Endereco", b =>
                {
                    b.HasOne("Etech.Entidades.Usuario", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("Etech.Entidades.Favorito", b =>
                {
                    b.HasOne("Etech.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoIdProduto");

                    b.HasOne("Etech.Entidades.Usuario", null)
                        .WithMany("Favoritos")
                        .HasForeignKey("UsuarioIdUsuario");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Etech.Entidades.Telefone", b =>
                {
                    b.HasOne("Etech.Entidades.Usuario", null)
                        .WithMany("Telefones")
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("Etech.Entidades.Carrinho", b =>
                {
                    b.Navigation("ProdutosCarrinho");
                });

            modelBuilder.Entity("Etech.Entidades.Compra", b =>
                {
                    b.Navigation("ProdutosCarrinho");

                    b.Navigation("ProdutosCompra");
                });

            modelBuilder.Entity("Etech.Entidades.Produto", b =>
                {
                    b.Navigation("ProdutosCarrinho");

                    b.Navigation("ProdutosCompra");
                });

            modelBuilder.Entity("Etech.Entidades.Usuario", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Emails");

                    b.Navigation("Enderecos");

                    b.Navigation("Favoritos");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
