using Dominio.Entidades;
using Dominio.Repositorio;

namespace Protheus.src.Aplicacao.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Usuario> ObterUsuarioAsync(string nomeUsuario, string senha)
        {
            var usuario = await _usuarioRepositorio.ObterUsuarioAsync(nomeUsuario, senha);

            return usuario;
        }
    }
}
