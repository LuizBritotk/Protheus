using Dominio.Entidades;

namespace Aplicacao.Servicos
{
    public interface IVendaServico
    {
        Task<IEnumerable<Venda>> ListarAsync();
        Task<Venda> ObterPorIdAsync(int vendaId);
        Task AdicionarAsync(Venda venda);
        Task AtualizarAsync(Venda venda);
        Task<IEnumerable<Venda>> ListarPorIdVendedorAsync(int id);
        Task<IEnumerable<Venda>> ListarPorCpfClienteAsync(string cpf);
        Task<IEnumerable<Venda>> ListarPorPeriodoAsync(DateTime dataInicio, DateTime dataFim);
    }
}
