using ApiComunicacao.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiComunicacao.Mapping
{
    public class UserMap : IEntityTypeConfiguration<ParametrosBody>
    {
        public void Configure(EntityTypeBuilder<ParametrosBody> builder)
        {
            builder.ToTable("AssecontMarcacoes");

            builder.Property(u => u.Id).IsRequired();

            builder.Property(u => u.NumeroSerie).IsRequired().HasMaxLength(60);

            builder.Property(u => u.Data).IsRequired();

            builder.Property(u => u.MarcacaoFuncionario).IsRequired();

            builder.Property(u => u.Status).IsRequired();


        }
    }
}
