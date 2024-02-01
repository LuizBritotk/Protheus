using Dominio.Entidades;

namespace Dominio.Repositorio
{
    public interface IVendaRepositorio
    {
        Task<IEnumerable<Venda>> ListarAsync();
        Task<Venda> ObterPorIdAsync(int vendaId);
        Task AdicionarAsync(Venda venda);
        Task AtualizarAsync(Venda venda);
        Task<IEnumerable<Venda>> ListarPorIdVendedorAsync(int idVendedor);
        Task<IEnumerable<Venda>> ListarPorCpfClienteAsync(string cpfCliente);
        Task<IEnumerable<Venda>> ListarPorPeriodoAsync(DateTime dataInicio, DateTime dataFim);
    }
}
