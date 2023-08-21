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
    internal class ProdutoCodigoBarraMap : IEntityTypeConfiguration<ProdutoCodigoBarra>
    {
        public void Configure(EntityTypeBuilder<ProdutoCodigoBarra> builder)
        {
            builder.ToTable("Produto_CodigoBarra");

            builder.HasKey(c => c.CodigoBarra);
            builder.Property(p=> p.CodigoBarra)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            builder.HasOne(p => p.Produto)
                .WithOne(p=>p.ProdutoCodigoBarra).HasForeignKey<ProdutoCodigoBarra>(p=>p.CodigoProduto);

            
        }
    }
}
