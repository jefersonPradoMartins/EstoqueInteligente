using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ProdutoFormulaSubstanciaMap : IEntityTypeConfiguration<ProdutoFormulaSubstancia>
    {
        public void Configure(EntityTypeBuilder<ProdutoFormulaSubstancia> builder)
        {
            builder.ToTable("Produto_Formula_Substancia");
            builder.HasKey(s => s.CodigoSubstancia);
        }
    }
}
