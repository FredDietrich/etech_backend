using Etech.Dal;
using Etech.Entidades;

namespace Etech.Bll;

public interface IUsuarioBLL
{
    Task<Usuario> Autentica(string login, string senha);
    Task<IEnumerable<Usuario>> ListaTodos();
}

public class UsuarioBLL : IUsuarioBLL
{

    UsuarioDAL usuarioDAL;
    DataContext _context;

    public UsuarioBLL(DataContext context)
    {
        usuarioDAL = new UsuarioDAL(context);
        _context = context;
    }

    public Task<Usuario> Autentica(string login, string senha)
    {
        var user = usuarioDAL.buscaUsuarioComSenha(login, senha);

        return user;
    }

    public async Task<IEnumerable<Usuario>> ListaTodos()
    {
        return await usuarioDAL.listaUsuarios();
    }

}