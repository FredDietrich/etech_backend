using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCategoria { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "O nome da categoria deve possuir até 50 caracteres")]
    public String? Nome { get; set; }

    [StringLength(255, ErrorMessage = "A descrição da categoria deve possuir até 255 caracteres")]
    public String? Descricao { get; set; }
}
