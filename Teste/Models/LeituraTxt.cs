using ApiComunicacao.Entities;
using System.Text;
using System.Text.RegularExpressions;
using Teste;

namespace ApiComunicacao.Models
{
    public class LeituraTxt
    {
        public string Id { get; set; }
        public string Data { get; set; }

        ParametrosBody parm = new ParametrosBody();

        public string CarregarParametros(string dados)
        {  
         
            string[] value = dados.Split("\\t", StringSplitOptions.RemoveEmptyEntries);
            parm.MarcacaoFuncionario = Convert.ToInt32(value[0]); 
            parm.Data = value[1];            

            return dados;
        }
    }
}
