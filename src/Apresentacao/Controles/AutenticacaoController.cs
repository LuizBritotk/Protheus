using Aplicacao.Servicos;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Protheus.src.Aplicacao.Filtro;

[ApiController]
[Route("api/[controller]")]
[ValidacaoModel]
public class AutenticacaoController : ControllerBase
{
    private readonly IUsuario _usuarioServico;

    public AutenticacaoController(IUsuario usuarioServico)
    {
        _usuarioServico = usuarioServico ?? throw new ArgumentNullException(nameof(usuarioServico));
    }

    [HttpPost("login")]
    public async Task<IActionResult> Autenticacao([FromBody] LoginAPI usuario)
    {
        try
        {
            var usuarioAutenticado = await _usuarioServico.ObterUsuarioAsync(usuario.Login, usuario.Senha);

            if (usuarioAutenticado == null)
            {
                return Unauthorized(new { message = "Credenciais inválidas." });
            }

            return Ok(new { message = "Autenticação bem-sucedida", usuario = usuarioAutenticado });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Ocorreu um erro durante a autenticação." });
        }
    }
}
