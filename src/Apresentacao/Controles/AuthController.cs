using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Protheus.src.Aplicacao.Servicos;
using Microsoft.AspNetCore.Authorization;
using Dominio.Entidades;

namespace Protheus.src.Apresentacao.Controles
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;

        public AutenticacaoController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Usuario usaurip)
        {
            var usuario = await _usuarioServico.ObterUsuarioAsync(usaurip.Nome, usaurip.Senha);

            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenServico.GerarToken(usuario);
            usuario.Senha = "";

            return new
            {
                usuario = usuario,
                token = token
            };
        }

        [HttpGet("anonimo")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet("autenticacao")]
        [Authorize]
        public string autenticacao() => $"Autenticado - {User.Identity.Name}";

        [HttpGet("funcionario")]
        [Authorize(Roles = "Gerente, Funcionario")]
        public string Employee() => "Funcionario";

        [HttpGet("gerente")]
        [Authorize(Roles = "Gerente")]
        public string Gerente() => "Gerente";
    }
}
