using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces.Repository;
using Microsoft.IdentityModel.Tokens;

namespace EstoqueInteligente.Infra.Repositories
{
    public class ProdutoFormulaRepository : IProdutoFormulaRepository
    {
        private readonly EstoqueInteligenteContext _context;

        public ProdutoFormulaRepository(EstoqueInteligenteContext context)
        {
            _context = context;
        }
        public Task AlterarFormula(ProdutoFormula produtoFormulaDto)
        {
            throw new NotImplementedException();
        }
        public async Task CadastrarFormula(ProdutoFormula produtoFormulaDto)
        {
            //var formula = new ProdutoFormula { NomeFormula = produtoFormulaDto.NomeFormula };
            //await _context.ProdutoFormula.AddAsync(formula);
            //await _context.SaveChangesAsync();

            //List<ProdutoFormulaSubstancia> ProdutoFormulaSubstancias = new List<ProdutoFormulaSubstancia>();

            //foreach (var codigo in produtoFormulaDto.CodigoSubstancia)
            //{
            //    ProdutoFormulaSubstancias.Add(new ProdutoFormulaSubstancia { CodigoSubstancia = codigo, CodigoFormula = formula.CodigoFormula });
            //}
            //await _context.ProdutoFormulaSubstancia.AddRangeAsync(ProdutoFormulaSubstancias);

            //await _context.SaveChangesAsync();
        }

        public Task CreateProdutoFormula(ProdutoFormula produtoFormula)
        {
            throw new NotImplementedException();
        }

        public async Task DeletarFormula(int CodigoFormula)
        {
          var result = _context.Produto.Where(p => p.ProdutoFormula.CodigoFormula == CodigoFormula);
            if (result.IsNullOrEmpty())
            {
                var rest = _context.ProdutoFormulaSubstancia.Where(p=>p.CodigoFormula == CodigoFormula);
                _context.ProdutoFormulaSubstancia.RemoveRange(rest);
                _context.SaveChanges();
                _context.ProdutoFormula.Remove(new ProdutoFormula { CodigoFormula = CodigoFormula});

            }
            await _context.SaveChangesAsync();
        }

        public Task<List<ProdutoFormula>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoFormula> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProdutoFormula(int CodigoFormula)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProdutoFormula(ProdutoFormula produtoFormula)
        {
            throw new NotImplementedException();
        }
    }
}
