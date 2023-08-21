using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Service.DTO;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IProdutoRepository : IDisposable
    {
        Task CadastrarProduto (ProdutoDto produtoDto);
        Task AlterarProduto(Produto produto);
        Task<IQueryable<Produto>> BuscarProdutos(bool ativo, bool eliminado);

    }
}
