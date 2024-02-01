using Dominio.Entidades;

namespace Protheus.src.Aplicacao.Servicos
{
    public interface IUsuarioServico
    {
        Task<Usuario> ObterUsuarioAsync(string? nome, string senha);
    }
}
