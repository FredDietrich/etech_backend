using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Compra
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCompra { get; set; }

    [Required]
    public int IdVendedor { get; set; }

    [Required]
    public int Quantidade { get; set; }

    [Required]
    public DateTime Data { get; set; }

    [Required]
    public String? Status { get; set; }
    public Double Desconto { get; set; }
}
