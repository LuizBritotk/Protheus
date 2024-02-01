namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public bool Ativo { get; set; }
        public string? Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int CPF { get; set; }
        public int? RG { get; set; }
    }
}
