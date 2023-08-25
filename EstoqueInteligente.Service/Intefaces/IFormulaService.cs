using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Service.Intefaces
{
    public interface IFormulaService
    {
        Task CreateFormula(FormulaDto produtoFormulaDto);
        Task UpdateFormula(FormulaDto produtoFormulaDto);
        Task RemoveFormula(int CodigoFormula);
        Task<FormulaOnlyDto> GetById(int id);
        Task<List<FormulaOnlyDto>> GetAll();
     
    }
}
