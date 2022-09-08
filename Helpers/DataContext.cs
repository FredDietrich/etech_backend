using Microsoft.EntityFrameworkCore;
using Etech.Entidades;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = Configuration.GetConnectionString("WebApiDatabase");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarrinhoProduto>()
            .HasKey(cp => new { cp.IdCarrinho, cp.IdProduto });
        modelBuilder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.Carrinho)
            .WithMany(c => c.ProdutosCarrinho)
            .HasForeignKey(cp => cp.IdCarrinho);
        modelBuilder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.Produto)
            .WithMany(p => p.ProdutosCarrinho)
            .HasForeignKey(cp => cp.IdProduto);
            
        modelBuilder.Entity<CompraProduto>()
            .HasKey(cp => new { cp.IdCompra, cp.IdProduto });
        modelBuilder.Entity<CompraProduto>()
            .HasOne(cp => cp.Compra)
            .WithMany(c => c.ProdutosCompra)
            .HasForeignKey(cp => cp.IdCompra);
        modelBuilder.Entity<CompraProduto>()
            .HasOne(cp => cp.Produto)
            .WithMany(p => p.ProdutosCompra)
            .HasForeignKey(cp => cp.IdProduto);
    }

    public DbSet<Carrinho>? Carrinhos { get; set; }
    public DbSet<CarrinhoProduto>? CarrinhoProdutos { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Compra>? Compras { get; set; }
    public DbSet<CompraProduto>? CompraProdutos { get; set; }
    public DbSet<Email>? Emails { get; set; }
    public DbSet<Endereco>? Enderecos { get; set; }
    public DbSet<Favorito>? Favoritos { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Telefone>? Telefones { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }
}