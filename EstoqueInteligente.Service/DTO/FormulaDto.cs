using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Service.DTO
{
    public record FormulaDto(string NomeFormula, List<int> CodigoSubstancia);
    public class FormulaOnlyDto
    {
        public int CodigoFormula { get; set; }
        public string NomeFormula { get; set; }

        public FormulaOnlyDto() { }
        public FormulaOnlyDto(int CodigoFormula, string NomeFormula)
        {
            this.CodigoFormula = CodigoFormula;
            this.NomeFormula = NomeFormula;
        }


    }

    public class SubstanciaDto
    {
        public int CodigoSubstancia { get; set; }
        public string NomeSubstancia { get; set; } = string.Empty;
        public SubstanciaDto() { }
        public SubstanciaDto(int CodigoSubstancia, string NomeSubstancia)
        {
            this.CodigoSubstancia = CodigoSubstancia;
            this.NomeSubstancia = NomeSubstancia;
        }
    }




}
