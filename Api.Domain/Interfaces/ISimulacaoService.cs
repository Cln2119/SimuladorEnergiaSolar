
using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Domain.Interfaces
{
    public interface ISimulacaoService
    {
        Task<Simulacao> Get(int user);
        Task<IEnumerable<Simulacao>> GetAll();
        Task<Simulacao> Post(int user);
        Task<Simulacao> Put(Simulacao user);
        Task<bool> Delete(int id);
    }
}
