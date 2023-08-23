using EstoqueInteligente.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IProdutoFormulaRepository
    {
        Task CadastrarFormula(ProdutoFormulaDto produtoFormulaDto);
        Task AlterarFormula(ProdutoFormulaDto produtoFormulaDto);
        Task DeletarFormula(int CodigoFormula);
    }
}
