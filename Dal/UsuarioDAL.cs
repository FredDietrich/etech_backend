using Etech.Entidades;

namespace Etech.Dal;

public class UsuarioDAL
{

    private DataContext _context;

    public UsuarioDAL(DataContext context)
    {
        _context = context;
    }

    public List<Usuario> listaUsuarios()
    {
        if (_context.Usuarios == null)
        {
            throw new Exception("Ocorreu um erro ao listar os usuários!");
        }
        return _context.Usuarios.ToList();
    }

    public Usuario cria(Usuario usuario)
    {
        if (_context.Usuarios == null)
        {
            throw new Exception("Ocorreu um erro ao criar o usuário!");
        }
        Usuario usuarioCriado = _context.Usuarios.Add(usuario).Entity;
        _context.SaveChanges();
        return usuarioCriado;
    }

}