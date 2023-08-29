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
    internal class ProdutoGrupoMap : IEntityTypeConfiguration<ProdutoGrupo>
    {
        public void Configure(EntityTypeBuilder<ProdutoGrupo> builder)
        {
            builder.ToTable("Produto_Grupo");
        }
    }
}
