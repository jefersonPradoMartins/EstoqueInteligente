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
    internal class ProdutoEstoqueLoteMap : IEntityTypeConfiguration<ProdutoEstoqueLote>
    {
        public void Configure(EntityTypeBuilder<ProdutoEstoqueLote> builder)
        {
            builder.ToTable("Produto_EstoqueLote");
            builder.HasKey(p => p.CodigoEstoqueLote);
            builder.Property(p => p.CodigoEstoqueLote)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            builder.HasOne(p => p.ProdutoEstoque)
                .WithOne(p => p.ProdutoEstoqueLote).HasForeignKey<ProdutoEstoqueLote>(p=>p.CodigoProdutoEstoque);
        }
    }
}
