using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ProdutoEstoqueControleMap : IEntityTypeConfiguration<ProdutoEstoqueControle>
    {
        public void Configure(EntityTypeBuilder<ProdutoEstoqueControle> builder)
        {
            builder.ToTable("Produto_EstoqueControle");
            builder.HasKey(p => p.CodigoEstoqueControle);
            builder.Property(p=>p.CodigoEstoqueControle)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            builder.HasOne(p => p.ProdutoEstoque)
                .WithOne(p => p.ProdutoEstoqueControle).HasForeignKey<ProdutoEstoqueControle>(p=>p.CodigoProdutoEstoque);
            builder.HasOne(e => e.ProdutoEmbalagem)
                .WithOne(p => p.ProdutoEstoqueControle).HasForeignKey<ProdutoEstoqueControle>(p=>p.CodigoProdutoEmbalagem);

        }
    }
}
