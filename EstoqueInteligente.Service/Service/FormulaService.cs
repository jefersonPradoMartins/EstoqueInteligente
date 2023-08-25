using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;

namespace EstoqueInteligente.Service.Service
{


    public class FormulaService : IFormulaService
    {

        private readonly IFormulaRepository _produtoFormulaRepository;

        public FormulaService(IFormulaRepository produtoFormulaRepository)
        {
            _produtoFormulaRepository = produtoFormulaRepository;
        }

        public async Task CreateFormula(FormulaDto produtoFormulaDto)
        {
            if(produtoFormulaDto.CodigoSubstancia.Count > 0)
            {

           

            Formula produtoFormula = new Formula { NomeFormula = produtoFormulaDto.NomeFormula };

            List<Substancia> substancias = new List<Substancia>();
            foreach (var substancia in produtoFormulaDto.CodigoSubstancia)
            {
                substancias.Add(new Substancia { CodigoSubstancia = substancia });
            }
            produtoFormula.Substancias = substancias;
            await _produtoFormulaRepository.CreateFormula(produtoFormula);
            }
        }

        public async Task<List<FormulaOnlyDto>> GetAll()
        {
            List<FormulaOnlyDto> formulaOnlyDtoList = new List<FormulaOnlyDto>();
            var result = await _produtoFormulaRepository.GetAll();
            foreach (var formula in result)
            {
                formulaOnlyDtoList.Add(new FormulaOnlyDto
                {
                    CodigoFormula = formula.CodigoFormula,
                    NomeFormula = formula.NomeFormula
                });
            }
            return formulaOnlyDtoList;
        }

        public Task<FormulaOnlyDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFormula(int CodigoFormula)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFormula(FormulaDto produtoFormulaDto)
        {
            throw new NotImplementedException();
        }


        //public bool ValidadeFormulaDto(FormulaDto formulaDto)
        //{

        //}
    }
}
