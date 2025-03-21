using OdontoprevApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(string id);
        Task<Cliente> CreateAsync(Cliente cliente);
        Task UpdateAsync(Cliente cliente);
        Task DeleteAsync(string id);
    }
}