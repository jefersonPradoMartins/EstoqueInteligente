using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class SubstanciaMap : IEntityTypeConfiguration<Substancia>
    {
        public void Configure(EntityTypeBuilder<Substancia> builder)
        {
            builder.ToTable("Substancia");
            builder.HasKey(s => s.CodigoSubstancia);


        }
    }
}
