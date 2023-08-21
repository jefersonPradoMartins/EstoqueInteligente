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
    internal class ContatoTipoMap : IEntityTypeConfiguration<ContatoTipo>
    {
        public void Configure(EntityTypeBuilder<ContatoTipo> builder)
        {
            builder.ToTable("Contato_Tipo");
            builder.HasKey(c => c.CodigoContatoTipo);
            builder.Property(c=>c.CodigoContatoTipo)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
        }
    }
}
