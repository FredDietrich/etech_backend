using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class CompraProduto
{
    [Required]
    public Double Quantidade { get; set; }
}