using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Service.DTO
{
    public record ProdutoFormulaDto(string NomeFormula, List<int> CodigoSubstancia);
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
