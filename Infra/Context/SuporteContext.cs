using Microsoft.EntityFrameworkCore;
using WebApiTest.Domain.Entities;

namespace WebApiTest.Infra.Context
{
    public class SuporteContext : DbContext
    {
        public SuporteContext(DbContextOptions<SuporteContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Chamado> Chamados { get; set; }

    }
}
