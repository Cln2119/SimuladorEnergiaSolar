using ApiComunicacao.Entities;
using Microsoft.EntityFrameworkCore;
using ApiComunicacao.Mapping;

namespace ApiComunicacao.Data
{
    public class MyContext : DbContext
    {
        public DbSet<ParametrosBody> Marcacoes { get; set; }     

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ParametrosBody>(new UserMap().Configure);
        }

    }
}
