using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Core.Structs;
using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Service.Intefaces
{
    public interface INCMService
    {
        Task UpdateAsync(NCMArquivo ncmArquivoDto);
        Task UpdateAsync(Nomenclaturas Nomenclatura);
        Task<Optional<Nomenclaturas>> CreateAsync(Nomenclaturas nomenclaturasDto);
        Task<NCM> GetByIdAsync(string Codigo);
        Task<IList<NCM>> GetAllAsync();
        Task RemoveAsync(string Codigo);
    }
}
