using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces.Repository;
using System.Data.Entity;

namespace EstoqueInteligente.Infra.Repositories
{
    public class SubstanciaRepository : ISubstanciaRepository
    {
        private readonly EstoqueInteligenteContext _context;

        public SubstanciaRepository(EstoqueInteligenteContext context)
        {
            _context = context;
        }
        public async Task CreateSubstancia(Substancia substancia)
        {
            await _context.Substancia.AddAsync(substancia);
            _context.SaveChanges();
        }

        public async Task DeleteSubstancia(int codigoSubstancia)
        {
            var result = await _context.Substancia.FindAsync(codigoSubstancia);
            if (result != null)
            {
                _context.Remove(result);
            }
        }

        public async Task<IList<Substancia>> GetAll()
        {
            return await _context.Substancia.ToListAsync();
        }

        public async Task<Substancia> GetById(int codigoSubstancia)
        {
            return await _context.Substancia.FindAsync(codigoSubstancia);
        }

        public async Task UpdateSubstancia(Substancia substancia)
        {
            _context.Substancia.Update(substancia);
            await _context.SaveChangesAsync();
        }
    }
}
