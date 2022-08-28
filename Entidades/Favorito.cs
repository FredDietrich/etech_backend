using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Favorito
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdFavorito { get; set; }
    public String? DtInclusao { get; set; }
    public String? DtAltercao { get; set; }
}
