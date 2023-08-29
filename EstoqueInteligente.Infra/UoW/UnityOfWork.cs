using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces;
using EstoqueInteligente.Infra.Interfaces.Repository;

namespace EstoqueInteligente.Infra.UoW
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly EstoqueInteligenteContext _context;

        public IProdutoRepository ProdutoRepository { get; }
        public IFormulaRepository FormulaRepository { get; }
        public ISubstanciaRepository SubstanciaRepository { get; }
        public IEnderecoRepository EnderecoRepository { get; }
        public IGrupoRepository GrupoRepository { get; }
        public INCMRepository NCMRepository { get; }

        public UnityOfWork(EstoqueInteligenteContext context, IProdutoRepository produtoRepository, IFormulaRepository formulaRepository, ISubstanciaRepository substanciaRepository, IEnderecoRepository enderecoRepository, IGrupoRepository grupoRepository, INCMRepository nCMRepository)
        {
            _context = context;
            ProdutoRepository = produtoRepository;
            FormulaRepository = formulaRepository;
            SubstanciaRepository = substanciaRepository;
            EnderecoRepository = enderecoRepository;
            GrupoRepository = grupoRepository;
            NCMRepository = nCMRepository;
        }

        public async Task<bool> CommitAsync()
        {
            var succes = (await _context.SaveChangesAsync() > 0);
            return succes;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
