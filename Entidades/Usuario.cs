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
    [StringLength(30, ErrorMessage = "O usuário deve possuir um login com no mínimo de 4 caracteres e no máximo 30", MinimumLength = 4)]
    public String? Login { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "O usuário deve possuir uma senha com mínimo 8 caracteres e no máximo 30", MinimumLength = 8)]
    public String? Senha { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "O usuário deve possuir um nome com no mínimo 3 letras e no máximo 100", MinimumLength = 3)]
    public String? Nome { get; set; }

    [Required]
    [StringLength(14, ErrorMessage = "O usuário precisa de um CPF", MinimumLength = 11)]
    public String? Cpf { get; set; }
    
    public Boolean Vendedor { get; set; } = false;
}