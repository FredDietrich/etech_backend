using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Telefone
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTelefone { get; set; }
    
    [Range(11, 99, ErrorMessage = "O DDD deve ser preenchido com um valor entre 11 e 99")]
    public int Ddd { get; set; }

    [Required]
    [Range(11111111, 999999999, ErrorMessage = "O telefone deve ter de 8 a 9 dígitos")]
    public int Numero { get; set; }
}
