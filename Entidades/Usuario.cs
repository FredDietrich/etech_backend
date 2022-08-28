using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Etech.Entidades;

public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUsuario { get; set; }

    [Required]
    [StringLength(12, ErrorMessage = "O usuário deve possuir um login! (mínimo de 4 e máximo de 12 caracteres)", MinimumLength = 4)]
    public String? Login { get; set; }

    [Required]
    [StringLength(16, ErrorMessage = "O usuário deve possuir uma senha com mínimo 8 caracteres e no máximo 16)", MinimumLength = 8)]
    public String? Senha { get; set; }

    [Required]
    [StringLength(32, ErrorMessage = "O usuário deve possuir um nome com no máximo 32 caracteres!")]
    public String? Nome { get; set; }

    [Required]
    [StringLength(11, ErrorMessage = "O usuário precisa de um CPF!")]
    public String? Cpf { get; set; }
    
    public Boolean Vendedor { get; set; } = false;

}