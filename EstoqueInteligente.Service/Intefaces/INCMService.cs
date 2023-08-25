using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Core.Structs;

namespace EstoqueInteligente.Service.Intefaces
{
    public interface INCMService
    {
        Task UpdateAsync(NCMArquivo ncmArquivoDto);
        Task UpdateAsync(Nomenclaturas Nomenclatura);
        Task<Optional<Nomenclaturas>> CreateAsync(Nomenclaturas nomenclaturasDto);
        Task<Optional<Nomenclaturas>> GetAsync(string Codigo);
        Task<IList<Nomenclaturas>> GetAllAsync();
        Task RemoveAsync(string Codigo);
    }
}
