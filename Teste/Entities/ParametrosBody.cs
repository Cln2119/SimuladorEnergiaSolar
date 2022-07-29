namespace ApiComunicacao.Entities
{
    public class ParametrosBody : BaseEntity
    {
        public string? NumeroSerie { get; set; }
        public string? Data { get; set; }
        public int MarcacaoFuncionario { get; set; }
        public int Status { get; set; }

    }
}
