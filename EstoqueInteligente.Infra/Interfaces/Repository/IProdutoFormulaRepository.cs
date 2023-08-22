using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    internal interface IProdutoFormulaRepository
    {
        Task CadastrarFormula(string formula);
        Task AlterarFormula(string formula);
        Task DeletarFormula(string formula);
    }
}
