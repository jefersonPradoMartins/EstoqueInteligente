using EstoqueInteligente.Core.Structs;
using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Service.Intefaces
{
    public interface ISubstanciaService 
    {
        Task UpdateAsync(SubstanciaDto substanciaDto);
        Task<Optional<SubstanciaDto>> CreateAsync(SubstanciaDto substanciaDto);
        Task<Optional<SubstanciaDto>> GetByIdAsync(string Codigo);
        Task<IList<SubstanciaDto>> GetAllAsync();
        Task RemoveAsync(string Codigo);
    }
}
