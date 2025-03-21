using OdontoprevApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(string id);
        Task<Cliente> AddAsync(Cliente cliente);
        Task UpdateAsync(Cliente cliente);
        Task DeleteAsync(string id);
    }
}