using EstoqueInteligente.Domain.Entities;


namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IProdutoRepository : IDisposable
    {
        Task CadastrarProduto (Produto produto);
        Task AlterarProduto(Produto produto);
        Task<IQueryable<Produto>> BuscarProdutos(bool ativo, bool eliminado);

    }
}
