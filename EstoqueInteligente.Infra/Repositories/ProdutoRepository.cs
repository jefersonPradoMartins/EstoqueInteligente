using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;

namespace EstoqueInteligente.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private Context.EstoqueInteligenteContext _context;

        public ProdutoRepository(Context.EstoqueInteligenteContext context)
        {
            _context = context;
        }
        

        public Task AlterarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Produto>> BuscarProdutos(bool ativo, bool eliminado)
        {
            throw new NotImplementedException();
        }

        public Task CadastrarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        //public async Task CadastrarProduto(ProdutoDto produtoDto)
        //{
        //    #region Produto
        //    Produto produto = new Produto
        //    {
        //        NomeProduto = produtoDto.NomeProduto,
        //        DescricaoCompletaProduto = produtoDto.DescricaoCompletaProduto,
        //        DescricaoResumidaProduto = produtoDto.DescricaoResumidaProduto,
        //        DataCadastro = DateTime.Now,
        //        RegistroMS = produtoDto.RegistroMS,
        //        Ativo = produtoDto.Ativo,
        //        Eliminado = false,
        //        NCM = new NCM { Codigo = produtoDto.NCM },
        //        ProdutoClasseTerapeutica = new ProdutoClasseTerapeutica { CodigoClasseTerapeutica = produtoDto.ProdutoClasseTerapeutica },
        //        ProdutoFormula = new ProdutoFormula { NomeFormula =  produtoDto.ProdutoFormulaDto.NomeFormula }
        //    };
        //    await _context.Produto.AddAsync(produto);
        //    Console.WriteLine(produto.CodigoProduto.ToString());
        //    #endregion
        //    #region Produto_Grupo
        //    List<Grupo> produtoGrupos = new List<Grupo>();
        //    foreach (var grupo in produtoDto.ProdutoGrupoDto)
        //    {
        //        if(grupo.CodigoGrupo == 0)
        //        {
        //            var result = await _context.Grupo.SingleOrDefaultAsync(x => x.NomeGrupo.Equals(grupo.NomeGrupo));
        //            if(result != null)
        //            {
        //                produtoGrupos.Add(result);
        //            }
        //            else
        //            {
        //                Grupo produtoGrupo = new Grupo { NomeGrupo = grupo.NomeGrupo };
        //                                 await _context.Grupo.AddAsync(produtoGrupo);
        //                var resultGrupo = await _context.Grupo.SingleOrDefaultAsync(x => x.NomeGrupo.Equals(grupo.NomeGrupo));

        //                produtoGrupos.Add(resultGrupo);
        //            }
        //        }
        //    }
        //    produto.Grupo = produtoGrupos;
        //    #endregion
        //    #region Produto_Estoque

        //    ProdutoEstoque produtoEstoque = new ProdutoEstoque
        //    {
        //        CodigoConfiguracaoEmpresa = 1,
        //        Estoque = produtoDto.ProdutoEstoqueDto.Estoque,
        //        CodigoProduto = produto.CodigoProduto
        //    };
        //    await _context.ProdutoEstoque.AddAsync(produtoEstoque);
        //    produto.ProdutoEstoque = produtoEstoque;

        //    #endregion
        //    #region Produto_Codigobarra
        //    List<ProdutoCodigoBarra> produtoCodigoBarraList = new List<ProdutoCodigoBarra>();
        //    foreach(var GTIN in produtoDto.ProdutoCodigoBarraDto)
        //    {
        //        if(GTIN.CodigoBarra == 0)
        //        {
        //            var result = await _context.ProdutoCodigoBarra.SingleOrDefaultAsync(x => x.GTIN.Equals(GTIN.GTIN));
        //            if (result != null)
        //            {
        //                produtoCodigoBarraList.Add(result);
        //            }
        //            else
        //            {
        //                ProdutoCodigoBarra prod = new ProdutoCodigoBarra
        //                {
        //                    CodigoProduto = produto.CodigoProduto,
        //                    GTIN = GTIN.GTIN
        //                };
        //                await _context.ProdutoCodigoBarra.AddAsync(prod);


        //                produtoCodigoBarraList.Add(prod);
        //            }
        //        }
        //    }
        //    produto.ProdutoCodigoBarra = produtoCodigoBarraList[0];
        //    #endregion

        //    _context.SaveChangesAsync();

        //}

        public void Dispose()
        {
            
        }
    }
}
