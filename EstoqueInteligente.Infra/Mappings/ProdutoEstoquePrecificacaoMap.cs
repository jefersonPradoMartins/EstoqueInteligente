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
    internal class ProdutoEstoquePrecificacaoMap : IEntityTypeConfiguration<ProdutoEstoquePrecificacao>
    {
        public void Configure(EntityTypeBuilder<ProdutoEstoquePrecificacao> builder)
        {
            builder.ToTable("Produto_EstoquePrecificacao");
            builder.HasKey(p => p.CodigoEstoquePrecificacao);
            builder.Property(p=>p.CodigoEstoquePrecificacao)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            builder.HasOne(p => p.ProdutoEstoque)
                .WithOne(p => p.ProdutoEstoquePrecificacao).HasForeignKey<ProdutoEstoquePrecificacao>(p=>p.CodigoProdutoEstoque);
        }
    }
}
