
namespace Infraestrutura.Excecoes
{
    public class UsuarioException : Exception
    {
        public UsuarioException() : base("Usuário não encontrado.")
        {
        }

        public UsuarioException(string mensagem) : base(mensagem)
        {
        }

        public UsuarioException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {
        }
    }
}
