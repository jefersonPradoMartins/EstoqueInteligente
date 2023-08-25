using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IFormulaRepository
    {
        Task CreateFormula(Formula formula);
        Task UpdateFormula(Formula formula);
        Task RemoveFormula(int CodigoFormula);
        Task<Formula>GetById(int CodigoFormula);
        Task<List<Formula>> GetAll();
    }
}
