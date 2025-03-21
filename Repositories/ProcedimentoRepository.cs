using Microsoft.EntityFrameworkCore;
using OdontoprevApi.Data;
using OdontoprevApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Repositories
{
    public class ProcedimentoRepository : IProcedimentoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProcedimentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Procedimento>> GetAllAsync()
        {
            return await _context.Procedimentos.ToListAsync();
        }

        public async Task<Procedimento> GetByIdAsync(string id)
        {
            return await _context.Procedimentos.FindAsync(id);
        }

        public async Task<Procedimento> AddAsync(Procedimento procedimento)
        {
            _context.Procedimentos.Add(procedimento);
            await _context.SaveChangesAsync();
            return procedimento;
        }

        public async Task UpdateAsync(Procedimento procedimento)
        {
            _context.Entry(procedimento).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var procedimento = await _context.Procedimentos.FindAsync(id);
            if (procedimento != null)
            {
                _context.Procedimentos.Remove(procedimento);
                await _context.SaveChangesAsync();
            }
        }
    }
}