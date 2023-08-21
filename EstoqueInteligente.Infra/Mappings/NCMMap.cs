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
    internal class NCMMap : IEntityTypeConfiguration<NCM>
    {
        public void Configure(EntityTypeBuilder<NCM> builder)
        {
            builder.ToTable("NCM");
            builder.HasKey(n => n.Codigo);
            builder.Property(n=>n.Ano_Ato).HasMaxLength(4);
            builder.Property(n=>n.Data_Fim).HasMaxLength(10);
            builder.Property(n=>n.Data_Inicio).HasMaxLength(10);
            builder.Property(n=>n.Numero_Ato).HasMaxLength(10);
            builder.Property(n=>n.Tipo_Ato).HasMaxLength(25);
        }
    }
}
