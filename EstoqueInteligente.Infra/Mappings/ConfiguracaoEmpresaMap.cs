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
    internal class ConfiguracaoEmpresaMap : IEntityTypeConfiguration<ConfiguracaoEmpresa>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoEmpresa> builder)
        {
            builder.ToTable("ConfiguracaoEmpresa");
            builder.HasKey(x => x.CodigoEmpresa);
            builder.Property(c => c.CodigoEmpresa)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.HasOne(p => p.PessoaJuridica)
                .WithOne(c => c.ConfiguracaoEmpresa)
                .HasForeignKey<ConfiguracaoEmpresa>(c=>c.CodigoPessoaJuridica);
                
        }
    }
}
