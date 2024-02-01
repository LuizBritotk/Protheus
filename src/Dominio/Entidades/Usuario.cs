namespace Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public bool Ativo {  get; set; }    
        public string Login { get; set; }
        public string Senha { get; set; }
        public string? Nome { get; set; }
        public int CPF { get; set; }
        public string? Email { get; set; }
        public string Regra { get; internal set; }
    }
}
