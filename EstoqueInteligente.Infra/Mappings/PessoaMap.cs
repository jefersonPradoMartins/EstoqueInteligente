using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(p => p.CodigoPessoa);
            builder.Property(p => p.CodigoPessoa)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();
        }
    }
}
