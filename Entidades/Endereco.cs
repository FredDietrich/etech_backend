using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Endereco
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idEndereco { get; set; }
    public Boolean Principal { get; set; }

    [StringLength(10, ErrorMessage = "Insira um CEP válido")]
    public String? Cep { get; set; }
    public String? Logradouro { get; set; }
    public String? Bairro { get; set; }
    public String? Cidade { get; set; }

    [StringLength(2, ErrorMessage = "O UF deve possuir 2 caracteres", MinimumLength = 2)]
    public String? Uf { get; set; }
    public String? Numero { get; set; }
    public String? Complemento { get; set; }
    public String? Referencia { get; set; }
}
