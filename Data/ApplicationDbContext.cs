
using OdontoPrevMVC.Models;

namespace OdontoprevApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Mapeamento para as tabelas – use os nomes conforme sua criação no Oracle
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
    }
}