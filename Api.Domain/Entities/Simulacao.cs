using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    public class Simulacao : BaseEntity
    {
      

        public string Media_Valor_Mensal { get; set; }
        public double? Media_Anual_Consumo_kWh { get; set; }
        public double? Potencia { get; set; }
        public double? Valor_Medio_Equipamento { get; set; }
        public double? Valor_Mao_De_Obra { get; set; }
        public double? Total_Investimento { get; set; }

        public Simulacao(string media_Valor_Mensal, double media_Anual_Consumo_kWh, double potencia, double valor_Medio_Equipamento, double valor_Mao_De_Obra, double total_Investimento)
        {
            Media_Valor_Mensal = media_Valor_Mensal;
            Media_Anual_Consumo_kWh = media_Anual_Consumo_kWh;
            Potencia = potencia;
            Valor_Medio_Equipamento = valor_Medio_Equipamento;
            Valor_Mao_De_Obra = valor_Mao_De_Obra;
            Total_Investimento = total_Investimento;
        }

        public Simulacao()
        {

        }


    }
   
}

