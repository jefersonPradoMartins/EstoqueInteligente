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
    internal class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(e => e.CodigoEndereco);
            builder.Property(e => e.CodigoEndereco)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasOne(c => c.Cidade)
                .WithOne(e => e.Endereco).HasForeignKey<Endereco>(e=>e.CodigoCidade);
            builder.HasOne(b => b.Bairro)
                .WithOne(e => e.Endereco).HasForeignKey<Endereco>(e=>e.CodigoBairro);
            builder.HasOne(e => e.Pessoa)
                .WithOne(e => e.Endereco).HasForeignKey<Endereco>(e => e.CodigoPessoa);


        }
    }
}
