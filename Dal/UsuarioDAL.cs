using Etech.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Etech.Dal;

public class UsuarioDAL
{

    private DataContext _context;

    public UsuarioDAL(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Usuario>> listaUsuarios()
    {
        if (_context.Usuarios == null)
        {
            throw new Exception("Ocorreu um erro ao listar os usuários!");
        }
        return await _context.Usuarios.ToListAsync();
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

    public async Task<Usuario> buscaUsuarioComSenha(string login, string senha)
    {
        if (_context.Usuarios == null)
        {
            throw new Exception("Ocorreu um erro ao buscar o usuário!");
        }
        Usuario usuarioEncontrado = await _context.Usuarios.FirstAsync(usuario => usuario.Login == login && usuario.Senha == senha);
        return usuarioEncontrado;
    }

}