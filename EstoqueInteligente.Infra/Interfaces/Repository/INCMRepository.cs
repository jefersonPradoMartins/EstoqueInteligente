using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface INCMRepository
    {
        Task AtualizarNCMArquivo(NCMArquivo arquivo);
        Task AlterarNCM(NCM ncm);
        Task DeletarNCM(string ncm);
        Task <NCM> BuscarNCMPorCodigo(string ncm);
    }
}
