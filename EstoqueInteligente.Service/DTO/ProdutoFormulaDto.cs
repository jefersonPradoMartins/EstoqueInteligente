using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Service.DTO
{
    public record ProdutoFormulaDto (string NomeFormula, List<int> CodigoSubstancia);
    public record SubstanciaDto(int CodigoSubstancia, string NomeSubstancia);
}
