namespace Dominio.Entidades
{
    public class ClienteAPI
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public List<UnidadeEntregaAPI> UnidadesEntrega { get; set; }
    }
}
