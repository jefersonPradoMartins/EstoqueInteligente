using EstoqueInteligente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface ISubstanciaRepository
    {
        Task CreateSubstancia(Substancia substancia);
        Task UpdateSubstancia(Substancia substancia);
        Task DeleteSubstancia(int codigoSubstancia);
        Task<Substancia> GetById(int codigoSubstancia);
        Task<IList<Substancia>> GetAll();
    }
}
