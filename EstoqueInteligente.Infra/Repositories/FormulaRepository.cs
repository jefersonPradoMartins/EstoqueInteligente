using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces.Repository;
using Microsoft.IdentityModel.Tokens;
using System.Data.Entity;

namespace EstoqueInteligente.Infra.Repositories
{
    public class FormulaRepository : IFormulaRepository
    {
        private readonly EstoqueInteligenteContext _context;

        public FormulaRepository(EstoqueInteligenteContext context)
        {
            _context = context;
        }

        public async Task CreateFormula(Formula formula)
        {
            Formula newFormula = new Formula{ NomeFormula = formula.NomeFormula};

            await _context.Formula.AddAsync(newFormula);
            await _context.SaveChangesAsync();

            List<FormulaSubstancia> formulaSubstanciaList = new List<FormulaSubstancia>();
           foreach (var substancia in formula.Substancias)
            {
                formulaSubstanciaList.Add(new FormulaSubstancia
                {
                    CodigoFormula = newFormula.CodigoFormula,
                    CodigoSubstancia = substancia.CodigoSubstancia
                });
            }
            await _context.FormulaSubstancia.AddRangeAsync(formulaSubstanciaList);
            _context.SaveChangesAsync();
        }

        public async Task<List<Formula>> GetAll()
        {
          return  _context.Formula.ToList();
        }

        public async Task<Formula> GetById(int CodigoFormula)
        {
           return await _context.Formula.FindAsync(CodigoFormula);
        }

        public  async Task RemoveFormula(int CodigoFormula)
        {
           var result = _context.Produto.AsNoTracking<Produto>().Where(x=>x.Formula.CodigoFormula == CodigoFormula);
           
            if (result.IsNullOrEmpty())
            {
                _context.Formula.Remove( new Formula { CodigoFormula = CodigoFormula });
               await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateFormula(Formula formula)
        {
           

             _context.Formula.Update(formula);

            //await _context.SaveChangesAsync();

            //List<FormulaSubstancia> formulaSubstanciaList = new List<FormulaSubstancia>();
            //foreach (var substancia in formula.Substancias)
            //{
            //    formulaSubstanciaList.Add(new FormulaSubstancia
            //    {
            //        CodigoFormula = newFormula.CodigoFormula,
            //        CodigoSubstancia = substancia.CodigoSubstancia
            //    });
            //}
            //await _context.FormulaSubstancia.AddRangeAsync(formulaSubstanciaList);
        }

        //public async Task Create(Formula produtoFormula)
        //{

        //    await _context.ProdutoFormula.AddAsync(produtoFormula);
        //    await _context.SaveChangesAsync();

        //    List<FormulaSubstancia> ProdutoFormulaSubstancias = new List<FormulaSubstancia>();

        //    foreach (var codigo in produtoFormula.Substancias)
        //    {
        //        ProdutoFormulaSubstancias.Add(new FormulaSubstancia { 
        //            CodigoSubstancia = codigo.CodigoSubstancia, CodigoFormula = produtoFormula.CodigoFormula});
        //    }
        //    await _context.ProdutoFormulaSubstancia.AddRangeAsync(ProdutoFormulaSubstancias);

        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeletarFormula(int CodigoFormula)
        //{
        //  var result = _context.Produto.Where(p => p.ProdutoFormula.CodigoFormula == CodigoFormula);
        //    if (result.IsNullOrEmpty())
        //    {
        //        var rest = _context.ProdutoFormulaSubstancia.Where(p=>p.CodigoFormula == CodigoFormula);
        //        _context.ProdutoFormulaSubstancia.RemoveRange(rest);
        //        _context.SaveChanges();
        //        _context.ProdutoFormula.Remove(new Formula { CodigoFormula = CodigoFormula});

        //    }
        //    await _context.SaveChangesAsync();
        //}


    }
}
