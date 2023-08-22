using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ProdutoFormulaMap : IEntityTypeConfiguration<ProdutoFormula>
    {
        public void Configure(EntityTypeBuilder<ProdutoFormula> builder)
        {
            builder.ToTable("Produto_Formula");
            builder.HasKey(c =>c.CodigoFurmula);

            builder.Property(c => c.CodigoFurmula)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            builder.HasMany(s => s.Substancias)
                .WithMany(f => f.ProdutoFormula).UsingEntity(j=>j.ToTable("Produto_Formula_substancia"));
        }
    }
}
