using OdontoprevApi.Models;
using OdontoprevApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Services
{
    public class ProcedimentoService : IProcedimentoService
    {
        private readonly IProcedimentoRepository _repository;

        public ProcedimentoService(IProcedimentoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Procedimento>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Procedimento> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Procedimento> CreateAsync(Procedimento procedimento)
        {
            return await _repository.AddAsync(procedimento);
        }

        public async Task UpdateAsync(Procedimento procedimento)
        {
            await _repository.UpdateAsync(procedimento);
        }

        public async Task DeleteAsync(string id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}