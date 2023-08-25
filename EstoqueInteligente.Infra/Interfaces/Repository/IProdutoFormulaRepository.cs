using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IProdutoFormulaRepository
    {
        Task CreateProdutoFormula(ProdutoFormula produtoFormula);
        Task UpdateProdutoFormula(ProdutoFormula produtoFormula);
        Task RemoveProdutoFormula(int CodigoFormula);
        Task<ProdutoFormula>GetById(int id);
        Task<List<ProdutoFormula>> GetAll();

    }
}
