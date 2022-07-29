using ApiComunicacao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ApiComunicacao.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {

            //Criar migrações
            var connectionString = "Server=serverrep01.assepontoteste.int\\HOMOLOG;Database=AssecontMarcacoes; Uid=AssecontMarcacoes;Pwd=As$3c0ntM";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);

        }
    }
}


