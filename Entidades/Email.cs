using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Email
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEmail { get; set; }

    [Required]
    [StringLength(45)]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
    public String? EnderecoEmail { get; set; }
}
