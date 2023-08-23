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

            List<ProdutoFormulaSubstancia> ProdutoFormulaSubstancias = new List<ProdutoFormulaSubstancia>();

            foreach (var codigo in produtoFormulaDto.CodigoSubstancia)
            {
                ProdutoFormulaSubstancias.Add(new ProdutoFormulaSubstancia { CodigoSubstancia = codigo, CodigoFormula = formula.CodigoFurmula });
            }
            await _context.ProdutoFormulaSubstancia.AddRangeAsync(ProdutoFormulaSubstancias);

            await _context.SaveChangesAsync();
        }

        public async Task DeletarFormula(int CodigoFormula)
        {
          var result = _context.Produto.Where(p => p.ProdutoFormula.CodigoFurmula == CodigoFormula);
            if (result.IsNullOrEmpty())
            {
                var rest = _context.ProdutoFormulaSubstancia.Where(p=>p.CodigoFormula == CodigoFormula);
                _context.ProdutoFormulaSubstancia.RemoveRange(rest);
                _context.SaveChanges();
                _context.ProdutoFormula.Remove(new ProdutoFormula { CodigoFurmula = CodigoFormula});

            }
            await _context.SaveChangesAsync();
        }
    }
}
