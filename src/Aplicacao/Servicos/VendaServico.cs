using Dominio.Repositorio;
using Dominio.Entidades;

namespace Aplicacao.Servicos
{
    public class VendaServico : IVendaServico
    {
        private readonly IVendaRepositorio _repositorioVenda;

        public VendaServico(IVendaRepositorio repositorioVenda)
        {
            _repositorioVenda = repositorioVenda;
        }

        public async Task<IEnumerable<Venda>> ListarAsync()
        {
            return await _repositorioVenda.ListarAsync();
        }

        public async Task<Venda> ObterPorIdAsync(int vendaId)
        {
            return await _repositorioVenda.ObterPorIdAsync(vendaId);
        }

        public async Task AdicionarAsync(Venda venda)
        {
            await _repositorioVenda.AdicionarAsync(venda);
        }

        public async Task AtualizarAsync(Venda venda)
        {
            await _repositorioVenda.AtualizarAsync(venda);
        }

        public async Task<IEnumerable<Venda>> ListarPorIdVendedorAsync(int id)
        {
            return await _repositorioVenda.ListarPorIdVendedorAsync(id);
        }

        public async Task<IEnumerable<Venda>> ListarPorCpfClienteAsync(string cpf)
        {
            return await _repositorioVenda.ListarPorCpfClienteAsync(cpf);
        }

        public async Task<IEnumerable<Venda>> ListarPorPeriodoAsync(DateTime dataInicio, DateTime dataFim)
        {
            return await _repositorioVenda.ListarPorPeriodoAsync(dataInicio, dataFim);
        }
    }
}
