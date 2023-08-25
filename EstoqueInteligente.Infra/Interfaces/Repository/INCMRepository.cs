using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface INCMRepository
    {
        Task CreateNCMAsync(List<NCM> arquivo);
        Task CreateNCMAsync(NCM ncm);
        Task CreateNCMEStatisticaAsync(NCMEStatistica ncm);
        Task UpdateNCMAsync(NCM ncm);
        Task RemoveNCM(string codigo);
        Task RemoveNCMEstatisticaAsync();
        Task<NCM> FindByIdAsync(string codigo);
        Task<List<NCM>> GetAllAsync();
    }
}
