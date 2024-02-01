using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Repositorio
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly VendasDb _context;

        public VendaRepositorio(VendasDb context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Venda>> ListarAsync()
        {
            return await _context.Vendas.ToListAsync();
        }

        public async Task<Venda> ObterPorIdAsync(int vendaId)
        {
            return await _context.Vendas.FirstOrDefaultAsync(venda => venda.Id == vendaId);
        }

        public async Task AdicionarAsync(Venda venda)
        {
            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Venda venda)
        {
            _context.Vendas.Update(venda);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Venda>> ListarPorIdVendedorAsync(int idVendedor)
        {
            return await _context.Vendas.Where(venda => venda.IdVendedor == idVendedor).ToListAsync();
        }

        public async Task<IEnumerable<Venda>> ListarPorCpfClienteAsync(string cpfCliente)
        {
            return await _context.Vendas.Where(venda => venda.CpfCliente == cpfCliente).ToListAsync();
        }

        public async Task<IEnumerable<Venda>> ListarPorPeriodoAsync(DateTime dataInicio, DateTime dataFim)
        {
            return await _context.Vendas.Where(venda => venda.Criacao >= dataInicio && venda.Criacao <= dataFim).ToListAsync();
        }
    }
}
