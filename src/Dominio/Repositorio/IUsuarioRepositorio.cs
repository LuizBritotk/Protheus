using Dominio.Entidades;

namespace Dominio.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> ObterUsuarioAsync(string nomeUsuario, string senha);
    }
}
