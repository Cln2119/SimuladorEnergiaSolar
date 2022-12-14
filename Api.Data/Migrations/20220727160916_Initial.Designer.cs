// <auto-generated />
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220727160916_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.Simulacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Media_Anual_Consumo_kWh")
                        .HasColumnType("double");

                    b.Property<string>("Media_Valor_Mensal")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Potencia")
                        .HasColumnType("double");

                    b.Property<double>("Total_Investimento")
                        .HasColumnType("double");

                    b.Property<double>("Valor_Mao_De_Obra")
                        .HasColumnType("double");

                    b.Property<double>("Valor_Medio_Equipamento")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("simulador");
                });
#pragma warning restore 612, 618
        }
    }
}
