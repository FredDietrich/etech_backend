using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Carrinho 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCarrinho { get; set; }

    public ICollection<CarrinhoProduto>? ProdutosCarrinho { get; set; }

}