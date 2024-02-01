using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Data
{
    public class VendasDb : DbContext
    {
        public DbSet<Venda> Vendas { get; set; }

        public VendasDb(DbContextOptions<VendasDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}