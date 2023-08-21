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
    internal class ProdutoEstatisticaMap : IEntityTypeConfiguration<ProdutoEstatistica>
    {
        public void Configure(EntityTypeBuilder<ProdutoEstatistica> builder)
        {
            builder.ToTable("Produto_Estatistica");
            builder.HasKey(p => p.CodigoEstatistica);
            builder.Property(p => p.CodigoEstatistica)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasOne(p => p.ProdutoEstoque)
                .WithOne(p => p.ProdutoEstatistica).HasForeignKey<ProdutoEstatistica>(p=>p.CodigoProdutoEstoque);

        }
    }
}
