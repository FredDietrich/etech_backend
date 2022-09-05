using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class CarrinhoProduto
{
    [Required]
    public Double Quantidade { get; set; }
}