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
    internal class ProdutoEmbalagemMap : IEntityTypeConfiguration<ProdutoEmbalagem>
    {
        public void Configure(EntityTypeBuilder<ProdutoEmbalagem> builder)
        {
            builder.ToTable("Produto_Embalagem");
            builder.HasKey(p=>p.CodigoEmbalagem);
            builder.Property(p=>p.CodigoEmbalagem)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            
        }
    }
}
