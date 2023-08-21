using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");
            builder.HasKey(c => c.CodigoContato);

            builder.Property(c=>c.CodigoContato)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasOne(t => t.ContatoTipo)
                .WithOne(c => c.Contato).HasForeignKey<Contato>(c=>c.CodigoContatoTipo);

            builder.HasOne(p => p.Pessoa)
                .WithOne(c => c.Contato).HasForeignKey<Contato>(p => p.CodigoPessoa);
        }
    }
}
