using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.Intefaces;

namespace EstoqueInteligente.Service.Service
{
    public class GrupoService : IGrupoService
    {
        private readonly IGrupoRepository _grupoRepository;

        public GrupoService(IGrupoRepository grupoRepository)
        {
            this._grupoRepository = grupoRepository;
        }

        public async Task CreateGrupoAsyc(Grupo grupo)
        {
          await  _grupoRepository.CreateGrupoAsyc(grupo);
        }

        public async Task DeleteGrupoAsyc(int codigoGrupo)
        {
            await _grupoRepository.DeleteGrupoAsyc(codigoGrupo);
        }

        public async Task<List<Grupo>> GetAll()
        {
           return await _grupoRepository.GetAll();
        }

        public async Task<Grupo> GetById(int codigoGrupo)
        {
            return await _grupoRepository.GetById(codigoGrupo);
        }

        public async Task<List<Grupo>> GetByName(string nomeGrupo)
        {
            return await _grupoRepository.GetByName(nomeGrupo);
        }

        public async Task UpdateGrupoAsyc(Grupo grupos)
        {
            await _grupoRepository.UpdateGrupoAsyc(grupos);
        }
    }
}
