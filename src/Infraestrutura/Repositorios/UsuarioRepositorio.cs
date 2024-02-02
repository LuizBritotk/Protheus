using Dominio.Entidades;
using Dominio.Repositorio;
using Infraestrutura.Data;
using Infraestrutura.Excecoes;
using Microsoft.EntityFrameworkCore;

public class UsuarioRepositorio : IUsuarioRepositorio
{
    private readonly PostgreDb _context;

    public UsuarioRepositorio(PostgreDb context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }


    public async Task<UsuarioAPI> ObterUsuarioAsync(string login, string senha)
    {
        var usuario = await _context.UsuarioAPI
            .FromSqlRaw("SELECT * FROM usuarioapiconsultar(@p0, @p1)", login, senha)
            .FirstOrDefaultAsync();

        if (usuario == null)
            throw new UsuarioException("Usuário não encontrado.");

        return usuario;
    }

    public async Task InserirUsuarioAsync(UsuarioAPI usuario)
    {
        await _context.Database.ExecuteSqlInterpolatedAsync(
            $"CALL usuarioapiinserir({usuario.Login}, {usuario.Senha}, {usuario.Ativo})");
    }

    public async Task AtualizarUsuarioAsync(UsuarioAPI usuario)
    {
        await _context.Database.ExecuteSqlInterpolatedAsync(
            $"CALL usuarioapiatualizar({usuario.Codigo}, {usuario.Login}, {usuario.Senha}, {usuario.Ativo})");
    }

    public async Task ExcluirUsuarioAsync(int codigo)
    {
        await _context.Database.ExecuteSqlInterpolatedAsync($"CALL usuarioapiexcluir({codigo})");
    }

    public async Task<IEnumerable<UsuarioAPI>> ListarUsuariosAsync()
    {
        var listaUsuarios = await _context.UsuarioAPI
            .FromSqlRaw("SELECT codigo, login, senha, ativo FROM usuarioapilistar()")
            .ToListAsync();

        return listaUsuarios;
    }
}
