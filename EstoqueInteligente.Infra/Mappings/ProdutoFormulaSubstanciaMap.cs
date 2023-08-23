﻿using EstoqueInteligente.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Mappings
{
    internal class ProdutoFormulaSubstanciaMap : IEntityTypeConfiguration<ProdutoFormulaSubstancia>
    {
        public void Configure(EntityTypeBuilder<ProdutoFormulaSubstancia> builder)
        {
            builder.ToTable("Produto_Formula_substancia");
         
        }
    }
}
