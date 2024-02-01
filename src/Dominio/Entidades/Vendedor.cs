
namespace Dominio.Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public bool Ativo { get; set; }

        public string? Nome { get; set; }
        public string? CPF { get; set; }

    }
}
