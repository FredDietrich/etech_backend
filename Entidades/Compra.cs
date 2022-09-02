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
    [DataType(DataType.DateTime)]
    [Display(Name = "Data Compra")]
    public DateTime Data { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "O status deve possuir no máximo 30 caracteres")]
    public String? Status { get; set; }
    
    public Double ValorTotal { get; set; }
}
