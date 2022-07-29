using ApiComunicacao.Entities;

namespace ApiComunicacao.Repository
{
    public interface IMarcacoesServices
    {
        Task<ParametrosBody> Get(Guid id);
        Task<IEquatable<ParametrosBody>> GetAll();
        Task<ParametrosBody> Post(ParametrosBody user);
        Task<ParametrosBody> Put(ParametrosBody user);
        Task<bool> Delete(Guid id);
    }
}
