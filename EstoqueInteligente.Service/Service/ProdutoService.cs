using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task CreateProduto(ProdutoDto produtoDto)
        {
            throw new NotImplementedException();
            //#region Produto
            //Produto produto = new Produto
            //{
            //    NomeProduto = produtoDto.NomeProduto,
            //    DescricaoCompletaProduto = produtoDto.DescricaoCompletaProduto,
            //    DescricaoResumidaProduto = produtoDto.DescricaoResumidaProduto,
            //    DataCadastro = DateTime.Now,
            //    RegistroMS = produtoDto.RegistroMS,
            //    Ativo = produtoDto.Ativo,
            //    Eliminado = false,
            //    NCM = new NCM { Codigo = produtoDto.NCM },
            //    ProdutoClasseTerapeutica = new ProdutoClasseTerapeutica { CodigoClasseTerapeutica = produtoDto.ProdutoClasseTerapeutica },
            //    ProdutoFormula = new Formula { NomeFormula = produtoDto.ProdutoFormulaDto.NomeFormula }
            //};
            // _produtoRepository.CreateProdutoAsync(produto);
            //#endregion
            //#region Produto_Grupo
            //List<Grupo> produtoGrupos = new List<Grupo>();
            //foreach (var grupo in produtoDto.ProdutoGrupoDto)
            //{
            //   //preciso adicionar o produto e grupo na tabela produto_grupo
            //}
            //produto.Grupo = produtoGrupos;
            //#endregion
            //#region Produto_Estoque

            //ProdutoEstoque produtoEstoque = new ProdutoEstoque
            //{
            //    CodigoConfiguracaoEmpresa = 1,
            //    Estoque = produtoDto.ProdutoEstoqueDto.Estoque,
            //    CodigoProduto = produto.CodigoProduto
            //};
            //await _context.ProdutoEstoque.AddAsync(produtoEstoque);
            //produto.ProdutoEstoque = produtoEstoque;

            //#endregion
            //#region Produto_Codigobarra
            //List<ProdutoCodigoBarra> produtoCodigoBarraList = new List<ProdutoCodigoBarra>();
            //foreach (var GTIN in produtoDto.ProdutoCodigoBarraDto)
            //{
            //    if (GTIN.CodigoBarra == 0)
            //    {
            //        var result = await _context.ProdutoCodigoBarra.SingleOrDefaultAsync(x => x.GTIN.Equals(GTIN.GTIN));
            //        if (result != null)
            //        {
            //            produtoCodigoBarraList.Add(result);
            //        }
            //        else
            //        {
            //            ProdutoCodigoBarra prod = new ProdutoCodigoBarra
            //            {
            //                CodigoProduto = produto.CodigoProduto,
            //                GTIN = GTIN.GTIN
            //            };
            //            await _context.ProdutoCodigoBarra.AddAsync(prod);


            //            produtoCodigoBarraList.Add(prod);
            //        }
            //    }
            //}
            //produto.ProdutoCodigoBarra = produtoCodigoBarraList[0];
            //#endregion

            //_context.SaveChangesAsync();
        }

        public Task DeleteProdutoAsync(int codigoProduto)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetAllAsync(bool ativo, bool eliminado)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetByCodigoBarra(int codigoBarra)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetByFormula(int codigoFormula)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetById(int codigoProduto)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> GetByName(int codigoProduto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProdutoAsync(ProdutoDto produtoDto)
        {
            throw new NotImplementedException();
        }
    }
}
