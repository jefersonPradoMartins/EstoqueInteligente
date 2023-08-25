using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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

  

        public async Task CreateProdutoAsync(Produto produto)
        {
            await _context.Produto.AddAsync(produto);
        }

        public async Task DeleteProdutoAsync(int codigoProduto)
        {
            _context.Produto.Where(x => x.CodigoProduto == codigoProduto)
                 .ExecuteUpdate(u => u.SetProperty(x => x.Eliminado, true));
           await _context.SaveChangesAsync();
        }

        //public async Task CadastrarProduto(ProdutoDto produtoDto)
        //{

        //}

        public void Dispose()
        {
            
        }

        public async Task<List<Produto>> GetAllAsync(bool ativo, bool eliminado)
        {
            var result = _context.Produto.Where(x=>x.Ativo ==ativo)
                .Where(x=>x.Eliminado ==eliminado).ToList();
            return result;
        }

        public Task<List<Produto>> GetByCodigoBarra(int codigoBarra)
        {
            var result =  _context.Produto.Where(x => x.ProdutoCodigoBarra.CodigoBarra == codigoBarra).ToListAsync();
            return result;
        }

        public async Task<List<Produto>> GetByFormula(int codigoFormula)
        {
            return await _context.Produto.Where(x => x.Formula.CodigoFormula == codigoFormula).ToListAsync();
        }

        public async Task<Produto> GetById(int codigoProduto)
        {
            return await _context.Produto.FindAsync(codigoProduto);
        }

        public async Task<List<Produto>> GetByName(string codigoProduto)
        {
            var result = await _context.Produto.Where(x => x.ProdutoCodigoBarra.GTIN == codigoProduto).ToListAsync();

            return result;
        }

        public Task<List<Produto>> GetByName(int codigoProduto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProdutoAsync(Produto produto)
        {
            var result = _context.Produto.AsNoTrackingWithIdentityResolution().AsQueryable().Where(x => x.CodigoProduto == produto.CodigoProduto);

            if (!result.IsNullOrEmpty())
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
