using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EstoqueInteligente.Infra.Repositories
{
    public class NCMRepository : INCMRepository
    {
        private readonly Context.EstoqueInteligenteContext _context;

        public NCMRepository(Context.EstoqueInteligenteContext context)
        {
            _context = context;
        }

        public async Task CreateNCMAsync(NCM ncm)
        {
            await _context.NCM.AddAsync(ncm);
            await _context.SaveChangesAsync();
        }
        public async Task CreateNCMAsync(List<NCM> arquivo)
        {
            await _context.NCM.AddRangeAsync(arquivo);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateNCMAsync(NCM ncm)
        {
            var result = _context.NCM.AsNoTrackingWithIdentityResolution().AsQueryable().Where(x => x.Codigo == ncm.Codigo);

           if(!result.IsNullOrEmpty())
            {
                 _context.Update(ncm);
                await _context.SaveChangesAsync();
            } 
          
        }
        public async Task RemoveNCM(string codigo)
        {
            var exists = _context.NCM.AsQueryable<NCM>().FirstOrDefault(x => x.Codigo.Equals(codigo));
            if (exists is not null)
            {
                var result = _context.Produto.AsQueryable<Produto>().FirstOrDefault(x => x.NCM.Equals(exists));
                if (result == null)
                {
                    _context.NCM.Remove(exists);
                    await _context.SaveChangesAsync();
                }
            }
        }
        public async Task<NCM> FindByIdAsync(string codigo)
        {
            return await _context.NCM.AsNoTracking<NCM>().FirstOrDefaultAsync(x => x.Codigo.Equals(codigo));
        }
        public async Task<List<NCM>> GetAllAsync()
        {
            return await _context.NCM.ToListAsync();
        }
        public async Task CreateNCMEStatisticaAsync(NCMEStatistica ncmEStatistica)
        {
            await _context.NCMEStatistica.AddAsync(ncmEStatistica);
            _context.SaveChanges();
        }

        public async Task RemoveNCMEstatisticaAsync()
        {
            await _context.NCMEStatistica.ExecuteDeleteAsync();
            _context.SaveChanges();
        }
    }
}
