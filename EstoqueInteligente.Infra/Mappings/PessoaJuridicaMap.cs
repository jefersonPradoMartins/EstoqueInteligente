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
    internal class PessoaJuridicaMap : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.ToTable("Pessoa_Juridica");

            builder.HasKey(p => p.CodigoPessoaJuridica);

            builder.Property(p => p.CodigoPessoaJuridica)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasOne(p => p.Pessoa)
              .WithOne(p => p.PessoaJuridica).HasForeignKey<PessoaJuridica>(p => p.CodigoPessoa);

            
        }
    }
}

