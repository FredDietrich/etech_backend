using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProduto { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "O título deve possuir até 100 caracteres")]
    public String? Titulo { get; set; }

    [StringLength(255, ErrorMessage = "A descricao da categoria deve possuir até 255 caracteres")]
    public String? Descricao { get; set; }

    [Required]
    public Double Preco { get; set; }

    [Required]
    public int QtdEstoque { get; set; }

    public Double Desconto { get; set; }
}
