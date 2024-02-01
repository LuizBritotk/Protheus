using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Data
{
    public class UsuarioDb : DbContext
    {
        public DbSet<Venda> Vendas { get; set; }

        public UsuarioDb(DbContextOptions<UsuarioDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}