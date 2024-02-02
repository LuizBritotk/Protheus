using Dominio.Entidades;

namespace Aplicacao.Servicos
{
    public interface IUsuario
    {
        Task InserirUsuarioAsync(UsuarioAPI usuario);
        Task AtualizarUsuarioAsync(UsuarioAPI usuario);
        Task ExcluirUsuarioAsync(int codigo);
        Task<IEnumerable<UsuarioAPI>> ListarUsuariosAsync();
        Task<UsuarioAPI> ObterUsuarioAsync(string login, string senha);
    }
}
