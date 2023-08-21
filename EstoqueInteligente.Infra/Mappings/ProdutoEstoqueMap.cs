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
    internal class ProdutoEstoqueMap : IEntityTypeConfiguration<ProdutoEstoque>
    {
        public void Configure(EntityTypeBuilder<ProdutoEstoque> builder)
        {
            builder.ToTable("Produto_Estoque");
            builder.HasKey(p => p.CodigoEstoque);
            builder.Property(p => p.CodigoEstoque)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasOne(p => p.ConfiguracaoEmpresa)
                .WithOne(p=>p.ProdutoEstoque).HasForeignKey<ProdutoEstoque>(p=>p.CodigoConfiguracaoEmpresa);
            builder.HasOne(p => p.Produto)
               .WithOne(p => p.ProdutoEstoque).HasForeignKey<ProdutoEstoque>(p => p.CodigoProduto);
        }
    }
}
