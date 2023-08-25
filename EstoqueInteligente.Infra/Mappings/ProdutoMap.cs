using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto")
                .HasMany(g => g.Grupo)
                .WithMany(p => p.Produtos).UsingEntity(p=>p.ToTable("Produto_Grupo"));

            builder.HasOne(p => p.NCM)
                .WithMany(n => n.Produtos);

            builder.HasOne(p => p.ProdutoClasseTerapeutica)
                .WithMany(p => p.Produto);

            builder.HasOne(p => p.Formula)
                .WithMany(p => p.Produto);

            builder.HasMany(p => p.Imagem)
                .WithMany(p => p.Produto).UsingEntity(p=>p.ToTable("Produto_Imagem"));

            builder.HasKey(p => p.CodigoProduto);

            builder.Property(p => p.CodigoProduto)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.Property(p=>p.NomeProduto).HasMaxLength(200).IsRequired(false);
            builder.Property(p=>p.DescricaoCompletaProduto).HasMaxLength(1000).IsRequired(false);
            builder.Property(p=>p.DescricaoResumidaProduto).HasMaxLength(100).IsRequired(false);
            builder.Property(p=>p.RegistroMS).HasMaxLength(20).IsRequired(false);
        }

    }
}
