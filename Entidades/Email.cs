using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Email
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEmail { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "O e-mail deve ter no máximo 50 caracteres")]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
    public String? EnderecoEmail { get; set; }
}
