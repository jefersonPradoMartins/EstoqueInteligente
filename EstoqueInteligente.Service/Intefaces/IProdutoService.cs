using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Service.Intefaces
{
    public interface IProdutoService
    {
        Task CreateProduto(ProdutoDto produtoDto);
        Task UpdateProdutoAsync(ProdutoDto produtoDto);
        Task DeleteProdutoAsync(int codigoProduto);
        Task<Produto> GetById(int codigoProduto);
        Task<List<Produto>> GetByName(int codigoProduto);
        Task<List<Produto>> GetByCodigoBarra(int codigoBarra);
        Task<List<Produto>> GetByFormula(int codigoFormula);
        Task<List<Produto>> GetAllAsync(bool ativo, bool eliminado);
    }
}
