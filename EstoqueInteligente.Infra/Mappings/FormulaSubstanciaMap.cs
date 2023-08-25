using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class FormulaSubstanciaMap : IEntityTypeConfiguration<FormulaSubstancia>
    {
        public void Configure(EntityTypeBuilder<FormulaSubstancia> builder)
        {
            builder.ToTable("Formula_Substancia");
        }
    }
}
