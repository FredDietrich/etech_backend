using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCategoria { get; set; }

    [StringLength(45, ErrorMessage = "O nome da categoria deve possuir até 45 caracteres")]
    public String? Nome { get; set; }

    [StringLength(45, ErrorMessage = "A descrição da categoria deve possuir até 45 caracteres")]
    public String? Descricao { get; set; }
}
