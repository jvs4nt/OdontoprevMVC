using OdontoprevApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Services
{
    public interface IProcedimentoService
    {
        Task<IEnumerable<Procedimento>> GetAllAsync();
        Task<Procedimento> GetByIdAsync(string id);
        Task<Procedimento> CreateAsync(Procedimento procedimento);
        Task UpdateAsync(Procedimento procedimento);
        Task DeleteAsync(string id);
    }
}