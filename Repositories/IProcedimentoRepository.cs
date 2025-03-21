using OdontoprevApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Repositories
{
    public interface IProcedimentoRepository
    {
        Task<IEnumerable<Procedimento>> GetAllAsync();
        Task<Procedimento> GetByIdAsync(string id);
        Task<Procedimento> AddAsync(Procedimento procedimento);
        Task UpdateAsync(Procedimento procedimento);
        Task DeleteAsync(string id);
    }
}