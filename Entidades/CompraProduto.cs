using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class CompraProduto
{

    public Produto? Produto { get; set; }

    public int IdProduto { get; set; }

    public Compra? Compra { get; set; }

    public int IdCompra { get; set; }

    [Required]
    public Double Quantidade { get; set; }

    
}