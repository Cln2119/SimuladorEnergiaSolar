using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Domain.Interfaces;


namespace Api.Service.Services
{
    public class UserService : ISimulacaoService
    {
        private IRepository<Simulacao> _repository;

        public UserService(IRepository<Simulacao> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Simulacao> Get(int id)
        {
            return await _repository.SelectAsync(id);
        }


        public async Task<IEnumerable<Simulacao>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<Simulacao> Post(Simulacao user)
        {
            return await _repository.InsertAsync(user);
        }

        public Task<Simulacao> Post(int user)
        {
            throw new NotImplementedException();
        }

        public async Task<Simulacao> Put(Simulacao user)
        {
            return await _repository.UpdateAsync(user);
        }

        public Task<Simulacao> Put(int user)
        {
            throw new NotImplementedException();
        }
    }
}
