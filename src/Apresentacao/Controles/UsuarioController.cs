using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Repositorio;
using Infraestrutura.Excecoes;
using Microsoft.AspNetCore.Mvc;

namespace SuaAplicacao.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio ?? throw new ArgumentNullException(nameof(usuarioRepositorio));
        }

        [HttpGet("{login}/{senha}")]
        public async Task<IActionResult> ObterUsuario(string login, string senha)
        {
            try
            {
                var usuario = await _usuarioRepositorio.ObterUsuarioAsync(login, senha);
                return Ok(usuario);
            }
            catch (UsuarioException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Ocorreu um erro durante a solicitação." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> InserirUsuario([FromBody] UsuarioAPI usuario)
        {
            try
            {
                await _usuarioRepositorio.InserirUsuarioAsync(usuario);
                return Ok(new { message = "Usuário inserido com sucesso." });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Ocorreu um erro durante a solicitação." });
            }
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarUsuario([FromBody] UsuarioAPI usuario)
        {
            try
            {
                await _usuarioRepositorio.AtualizarUsuarioAsync(usuario);
                return Ok(new { message = "Usuário atualizado com sucesso." });
            }
            catch (UsuarioException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Ocorreu um erro durante a solicitação." });
            }
        }

        [HttpDelete("{codigo}")]
        public async Task<IActionResult> ExcluirUsuario(int codigo)
        {
            try
            {
                await _usuarioRepositorio.ExcluirUsuarioAsync(codigo);
                return Ok(new { message = "Usuário excluído com sucesso." });
            }
            catch (UsuarioException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Ocorreu um erro durante a solicitação." });
            }
        }

        [HttpGet]
        public async Task<IActionResult> ListarUsuarios()
        {
            try
            {
                var listaUsuarios = await _usuarioRepositorio.ListarUsuariosAsync();
                return Ok(listaUsuarios);
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Ocorreu um erro durante a solicitação." });
            }
        }
    }
}
