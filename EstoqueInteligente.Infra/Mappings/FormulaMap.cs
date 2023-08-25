using Azure;
using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class FormulaMap : IEntityTypeConfiguration<Formula>
    {
        public void Configure(EntityTypeBuilder<Formula> builder)
        {
            builder.ToTable("Formula");
            builder.HasKey(c => c.CodigoFormula);

            builder.Property(c => c.CodigoFormula)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasMany(s => s.Substancias)
                .WithMany(f => f.ProdutoFormula)
               .UsingEntity<FormulaSubstancia>(
            l => l.HasOne<Substancia>().WithMany().HasForeignKey(e => e.CodigoSubstancia),
            r => r.HasOne<Formula>().WithMany().HasForeignKey(e => e.CodigoFormula),
            o=>o.ToTable("Formula_Substancia"));
        }
    }
}
