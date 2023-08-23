using Azure;
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
            builder.HasKey(c => c.CodigoFurmula);

            builder.Property(c => c.CodigoFurmula)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasMany(s => s.Substancias)
                .WithMany(f => f.ProdutoFormula)
               .UsingEntity<ProdutoFormulaSubstancia>(
            l => l.HasOne<Substancia>().WithMany().HasForeignKey(e => e.CodigoSubstancia),
            r => r.HasOne<ProdutoFormula>().WithMany().HasForeignKey(e => e.CodigoFormula),
            o=>o.ToTable("Produto_Formula_Substancia"));
        }
    }
}
