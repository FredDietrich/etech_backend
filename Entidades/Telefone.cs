using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Telefone
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTelefone { get; set; }
    
    [Required]
    [StringLength(2, ErrorMessage = "O telefone deve conter um DDD!")]
    public String? Ddd { get; set; }

    [Required]
    [StringLength(9, ErrorMessage = "O telefone deve conter um número com no mínimo 8 dígitos e no máximo 9!", MinimumLength = 8)]
    public String? Numero { get; set; }


}
