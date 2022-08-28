using Etech.Dal;
using Etech.Entidades;

namespace Etech.Bll;

public class UsuarioBLL
{

    UsuarioDAL usuarioDAL;
    DataContext _context;

    public UsuarioBLL(DataContext context)
    {
        usuarioDAL = new UsuarioDAL(context);
        _context = context;
    }

}