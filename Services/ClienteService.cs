using OdontoprevApi.Models;
using OdontoprevApi.Repositories;

namespace OdontoprevApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Cliente> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Cliente> CreateAsync(Cliente cliente)
        {
            return await _repository.AddAsync(cliente);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            await _repository.UpdateAsync(cliente);
        }

        public async Task DeleteAsync(string id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}