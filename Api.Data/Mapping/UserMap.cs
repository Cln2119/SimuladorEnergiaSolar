using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<Simulacao>
    {
        public void Configure(EntityTypeBuilder<Simulacao> builder)
        {
            builder.ToTable("simulador");

            builder.Property(u => u.Media_Valor_Mensal).IsRequired();

            builder.Property(u => u.Media_Anual_Consumo_kWh).IsRequired();

            builder.Property(u => u.Potencia).IsRequired();

            builder.Property(u => u.Valor_Medio_Equipamento).IsRequired();

            builder.Property(u => u.Valor_Mao_De_Obra).IsRequired();

            builder.Property(u => u.Total_Investimento).IsRequired();

        }


    }

  
}
