using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Repositorio
{
    public class UsuarioRepositorio
    {
        private static readonly HashSet<Usuario> Usuarios = new HashSet<Usuario>
        {
            new Usuario { Id = 1, Login = "Luiz", Senha = "Luiz@Lojao", Regra = "Funcionario" },
            new Usuario { Id = 2, Login = "Bruno", Senha = "Bruno@Lojao", Regra = "Gerente" }
        };

        public static async Task<Usuario> ObterUsuarioAsync(string login, string senha)
        {
            await Task.Delay(1);

            return Usuarios.FirstOrDefault(usaurio => usaurio.Login.ToLowerInvariant() == login.ToLowerInvariant() && usaurio.Senha == senha);
        }
    }
}
