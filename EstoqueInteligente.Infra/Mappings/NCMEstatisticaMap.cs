using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class NCMEstatisticaMap : IEntityTypeConfiguration<NCMEStatistica>
    {
        public void Configure(EntityTypeBuilder<NCMEStatistica> builder)
        {
            builder.ToTable("NCM_Estatistica");
            builder.HasKey(n=>n.CodigoNCMEstatistica);
            builder.Property(n => n.CodigoNCMEstatistica).UseIdentityColumn().ValueGeneratedOnAdd();
            builder.Property(n=>n.Data_Ultima_Atualizacao_NCM).HasMaxLength(10);
            builder.Property(n=>n.Ato).HasMaxLength(100);
        }
    }
}
