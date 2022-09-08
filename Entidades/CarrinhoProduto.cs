using System.ComponentModel.DataAnnotations;

namespace Etech.Entidades;

public class CarrinhoProduto
{
    public int IdCarrinho { get; set; }

    public Carrinho? Carrinho { get; set; }

    public int IdProduto { get; set; }

    public Produto? Produto { get; set; }

    [Required]
    public Double Quantidade { get; set; }
}