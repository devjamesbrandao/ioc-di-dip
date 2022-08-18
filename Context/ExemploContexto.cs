using ioc_di_dip.Model;
using Microsoft.EntityFrameworkCore;

namespace ioc_di_dip.Context
{
    public class ExemploContext : DbContext
    {
        public ExemploContext(){  }

        public ExemploContext(DbContextOptions<ExemploContext> options) : base(options){ }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}