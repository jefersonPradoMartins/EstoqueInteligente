using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ProdutoClasseTerapeuticaMap : IEntityTypeConfiguration<ProdutoClasseTerapeutica>
    {
        public void Configure(EntityTypeBuilder<ProdutoClasseTerapeutica> builder)
        {
            builder.ToTable("Produto_ClasseTerapeutica");

            builder.HasKey(c => c.CodigoClasseTerapeutica);
        }
    }
}
