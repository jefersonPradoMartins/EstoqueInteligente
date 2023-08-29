using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IGrupoRepository
    {
        Task CreateGrupoAsyc(Grupo grupo);
        Task UpdateGrupoAsyc(Grupo grupo);
        Task DeleteGrupoAsyc(int codigoGrupo);
        Task<Grupo> GetById(int codigoGrupo);
        Task<List<Grupo>> GetAll();
        Task<List<Grupo>> GetByName(string nomeGrupo);
    }
}
