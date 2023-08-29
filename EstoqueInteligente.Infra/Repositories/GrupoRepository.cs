using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces.Repository;
using System.Data.Entity;

namespace EstoqueInteligente.Infra.Repositories
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly EstoqueInteligenteContext _context;

        public GrupoRepository(EstoqueInteligenteContext context)
        {
            _context = context;
        }

        public async Task CreateGrupoAsyc(Grupo grupo)
        {
           await _context.Grupo.AddRangeAsync(grupo);
        }

        public async Task DeleteGrupoAsyc(int codigoGrupo)
        {
            var result = _context.ProdutoGrupo.Where(x => x.CodigoGrupo == codigoGrupo);
            if(result.Count() == 0)
            {
                _context.Grupo.Remove(new Grupo { CodigoGrupo = codigoGrupo });
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Grupo>> GetAll()
        {
            return await _context.Grupo.ToListAsync();
        }

        public async Task<Grupo> GetById(int codigoGrupo)
        {
            return  await _context.Grupo.AsNoTracking<Grupo>().FirstAsync(x=>x.CodigoGrupo == codigoGrupo);
        }

        public async Task<List<Grupo>> GetByName(string nomeGrupo)
        {
            return await _context.Grupo.AsNoTracking<Grupo>().Where(x=>x.NomeGrupo == nomeGrupo).ToListAsync();
        }

        public async Task UpdateGrupoAsyc(Grupo grupo)
        {
            _context.Grupo.Update(grupo);
          await  _context.SaveChangesAsync();
        }
    }
}
