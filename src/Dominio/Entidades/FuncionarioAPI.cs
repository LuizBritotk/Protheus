namespace Dominio.Entidades
{
    public class FuncionarioAPI
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public bool Ativo { get; set; }
    }
}
