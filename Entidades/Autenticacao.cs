namespace Etech.Entidades;

using System.ComponentModel.DataAnnotations;

public class Autenticacao
{
    [Required]
    public string Login { get; set; } = "";

    [Required]
    public string Senha { get; set; } = "";
}