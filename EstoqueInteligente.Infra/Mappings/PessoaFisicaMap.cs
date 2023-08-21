using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.ToTable("Pessoa_Fisica");
            builder.HasKey(p => p.CodigoPessoaFisica);
            builder.Property(p => p.CodigoPessoaFisica)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
            
            builder.HasOne(p => p.Pessoa)
                .WithOne(p => p.PessoaFisica).HasForeignKey<PessoaFisica>(p=>p.CodigoPessoa);
            builder.Property(p => p.DataNascimento).HasColumnType("smalldatetime");

        }
    }
}
