namespace EstoqueInteligente.Infra.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        Task<bool> CommitAsync();
        Task Rollback();
    }
}
