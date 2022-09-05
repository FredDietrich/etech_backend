using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Endereco 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEndereco { get; set; }

    public Boolean Principal { get; set; } = false;

    [Range(0, 99999999, ErrorMessage = "O CEP deve ser informado com um valor entre 0 e 99999999")]
    public int Cep { get; set; }
    
    [StringLength(60, ErrorMessage = "O logradouro deve conter no máximo 60 caracteres")]
    public String? Logradouro { get; set; }

    [StringLength(60, ErrorMessage = "O bairro deve conter no máximo 60 caracteres")]
    public String? Bairro { get; set; }

    [StringLength(60, ErrorMessage = "A cidade deve conter no máximo 60 caracteres")]
    public String? Cidade { get; set; }

    [StringLength(2, ErrorMessage = "O UF deve possuir 2 caracteres", MinimumLength = 2)]
    public String? Uf { get; set; }

    [Range(0, 100000)]
    public int Numero { get; set; }

    [StringLength(50, ErrorMessage = "O complemento deve conter no máximo 50 caracteres")]
    public String? Complemento { get; set; }

    [StringLength(60, ErrorMessage = "A referência deve conter no máximo 255 caracteres")]
    public String? Referencia { get; set; }
}
