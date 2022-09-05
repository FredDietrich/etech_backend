using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etech.Entidades;

public class Favorito
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdFavorito { get; set; }

    public Produto? Produto { get; set; }

}
