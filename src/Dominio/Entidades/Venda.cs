namespace Dominio.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }

        public string? CodigoOrdem { get; set; }
        public decimal ValorBruto { get; set; }     // Valor antes de descontos
        public decimal ValorDesconto { get; set; }  // Valor dos descontos aplicados
        public decimal ValorTotal { get; set; }     // Valor final após descontos
        public string? CpfCliente { get; set; }
        public int IdVendedor { get; set; }

        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
