using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Data
{
    public class PostgreDb : DbContext
    {
        public DbSet<UsuarioAPI> UsuarioAPI { get; set; }

        public PostgreDb(DbContextOptions<PostgreDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioAPI>().HasKey(usuario => usuario.Codigo);

            base.OnModelCreating(modelBuilder);
        }
    }
}
