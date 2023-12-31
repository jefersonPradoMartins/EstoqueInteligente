﻿using EstoqueInteligente.Domain.Entities;


namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IProdutoRepository : IDisposable
    {
        Task CreateProdutoAsync (Produto produto);
        Task UpdateProdutoAsync(Produto produto);
        Task DeleteProdutoAsync(int codigoProduto);
        Task<Produto> GetById(int codigoProduto);
        Task<List<Produto>> GetByName(int codigoProduto);
        Task<List<Produto>> GetByCodigoBarra(int codigoBarra);
        Task<List<Produto>> GetByFormula(int codigoFormula);
        Task<List<Produto>> GetAllAsync(bool ativo, bool eliminado);

    }
}
