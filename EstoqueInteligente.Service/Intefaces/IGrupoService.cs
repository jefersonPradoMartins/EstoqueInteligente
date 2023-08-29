using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Service.Intefaces
{
    public interface IGrupoService
    {
        Task CreateGrupoAsyc(Grupo grupo);
        Task UpdateGrupoAsyc(Grupo grupo);
        Task DeleteGrupoAsyc(int codigoGrupo);
        Task<Grupo> GetById(int codigoGrupo);
        Task<List<Grupo>> GetAll();
        Task<List<Grupo>> GetByName(string nomeGrupo);
    }
}
