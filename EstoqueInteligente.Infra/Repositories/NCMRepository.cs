
using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using Microsoft.EntityFrameworkCore;

namespace EstoqueInteligente.Infra.Repositories
{
    public class NCMRepository : INCMRepository
    {
        private readonly Context.Context _context;

        public NCMRepository(Context.Context context)
        {
            _context = context;
        }

        public async Task AlterarNCM(Nomenclaturas ncm)
        {

            var result = await _context.NCM.AsNoTracking<NCM>().FirstOrDefaultAsync(x => x.Codigo.Equals(ncm.Codigo));
            if (result != null)
            {
                _context.NCM.Update(
                new NCM
                {
                    Codigo = ncm.Codigo,
                    Ano_Ato = ncm.Ano_Ato,
                    Data_Fim = ncm.Data_Fim,
                    Data_Inicio = ncm.Data_Inicio,
                    Descricao = ncm.Descricao,
                    Numero_Ato = ncm.Numero_Ato,
                    Tipo_Ato = ncm.Tipo_Ato,
                });
            }
        }

        public Task<NCM> BuscarNCMPorCodigo(string ncm)
        {
            throw new NotImplementedException();
        }

        public async Task AtualizarNCMArquivo(NCMArquivo arquivo)
        {
            await _context.NCMEStatistica.ExecuteDeleteAsync();

            await _context.NCMEStatistica.AddAsync(new NCMEStatistica
            {
                Ato = arquivo.Ato,
                Data_Ultima_Atualizacao_NCM = arquivo.Data_Ultima_Atualizacao_NCM
            });



            foreach (var ncm in arquivo.Nomenclaturas)
            {

                var result = _context.NCM.AsNoTracking<NCM>().FirstOrDefault(x => x.Codigo.Equals(ncm.Codigo));
                if (result != null)
                {
                    _context.NCM.Update(
                    new NCM
                    {
                        Codigo = ncm.Codigo,
                        Ano_Ato = ncm.Ano_Ato,
                        Data_Fim = ncm.Data_Fim,
                        Data_Inicio = ncm.Data_Inicio,
                        Descricao = ncm.Descricao,
                        Numero_Ato = ncm.Numero_Ato,
                        Tipo_Ato = ncm.Tipo_Ato,
                    });
                }
                else
                {
                    await _context.NCM.AddAsync(
                     new NCM
                     {
                         Codigo = ncm.Codigo,
                         Ano_Ato = ncm.Ano_Ato,
                         Data_Fim = ncm.Data_Fim,
                         Data_Inicio = ncm.Data_Inicio,
                         Descricao = ncm.Descricao,
                         Numero_Ato = ncm.Numero_Ato,
                         Tipo_Ato = ncm.Tipo_Ato,
                     });
                }

            }

            await _context.SaveChangesAsync();
        }

        public async Task DeletarNCM(string ncm)
        {
            var result = _context.Produto.AsNoTracking<Produto>().FirstOrDefault(x => x.NCM.Codigo.Equals(ncm));

            if (result == null)
            {
                _context.NCM.Remove(new NCM { Codigo = ncm });
            }

            await _context.SaveChangesAsync();
        }
        public async Task CadastrarNCM(Nomenclaturas ncm)
        {
            await _context.NCM.AddAsync(
                   new NCM
                   {
                       Codigo = ncm.Codigo,
                       Ano_Ato = ncm.Ano_Ato,
                       Data_Fim = ncm.Data_Fim,
                       Data_Inicio = ncm.Data_Inicio,
                       Descricao = ncm.Descricao,
                       Numero_Ato = ncm.Numero_Ato,
                       Tipo_Ato = ncm.Tipo_Ato,
                   });
            await _context.SaveChangesAsync();
        }
    }
}
