using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using Microsoft.EntityFrameworkCore;
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

        public Task AlterarFormula(ProdutoFormulaDto produtoFormulaDto)
        {
            throw new NotImplementedException();
        }

        public async Task CadastrarFormula(ProdutoFormulaDto produtoFormulaDto)
        {
            var formula = new ProdutoFormula { NomeFormula = produtoFormulaDto.NomeFormula };
            await _context.ProdutoFormula.AddAsync(formula);
            await _context.SaveChangesAsync();

            List<ProdutoFormulaSubstancia> pfs = new List<ProdutoFormulaSubstancia>();

            foreach (var codigo in produtoFormulaDto.CodigoSubstancia)
            {
                pfs.Add(new ProdutoFormulaSubstancia { CodigoSubstancia = codigo, CodigoFormula = formula.CodigoFurmula });
            }
            await _context.ProdutoFormulaSubstancia.AddRangeAsync(pfs);

            await _context.SaveChangesAsync();
        }

        public async Task DeletarFormula(int CodigoFormula)
        {
          var result = _context.Produto.Where(p => p.ProdutoFormula.CodigoFurmula == CodigoFormula);
            if (result.IsNullOrEmpty())
            {
                _context.ProdutoFormulaSubstancia.Remove(
                    new ProdutoFormulaSubstancia { CodigoFormula = CodigoFormula});
                _context.ProdutoFormula.Remove(new ProdutoFormula { CodigoFurmula = CodigoFormula});

            }
            await _context.SaveChangesAsync();
        }
    }
}
