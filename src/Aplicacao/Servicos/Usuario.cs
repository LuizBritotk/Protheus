using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Repositorio;

namespace Aplicacao.Servicos
{
    public class Usuario : IUsuario
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public Usuario(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task InserirUsuarioAsync(UsuarioAPI usuario)
        {

            await _usuarioRepositorio.InserirUsuarioAsync(usuario); 
        }

        public async Task AtualizarUsuarioAsync(UsuarioAPI usuario)
        {

            await _usuarioRepositorio.AtualizarUsuarioAsync(usuario);
        }

        public async Task ExcluirUsuarioAsync(int codigo)
        {

            await _usuarioRepositorio.ExcluirUsuarioAsync(codigo);
        }

        public async Task<IEnumerable<UsuarioAPI>> ListarUsuariosAsync()
        {

            return await _usuarioRepositorio.ListarUsuariosAsync();
        }

        public async Task<UsuarioAPI> ObterUsuarioAsync(string login, string senha)
        {
            return await _usuarioRepositorio.ObterUsuarioAsync(login, senha);
        }
    }
}



//{
//    "id": 0,
//  "criacao": "2024-02-02T12:09:02.971Z",
//  "ativo": true,
//  "login": "Luiz.Brito",
//  "senha": "Lojao@1234",
//  "nome": "Luiz Americo Brito",
//  "cpf": "37331853821",
//  "email": "Luiz.Brito@lojaobras.com"
//}
