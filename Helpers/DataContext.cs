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

    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Compra>? Compras { get; set; }
    public DbSet<Email>? Emails { get; set; }
    public DbSet<Endereco>? Enderecos { get; set; }
    public DbSet<Favorito>? Favoritos { get; set; }
    public DbSet<Produto>? Telefone { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }

}