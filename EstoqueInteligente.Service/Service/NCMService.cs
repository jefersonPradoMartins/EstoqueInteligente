using EstoqueInteligente.Core.Structs;
using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;
using static EstoqueInteligente.Service.Service.NCMService;

namespace EstoqueInteligente.Service.Service
{
    public class NCMService : INCMService
    {
        private readonly INCMRepository _ncmRepository;

        public NCMService(INCMRepository ncmRepository)
        {
            _ncmRepository = ncmRepository;
        }

        public async Task<Optional<Nomenclaturas>> CreateAsync(Nomenclaturas nomenclaturasDto)
        {
            NCM ncm = new NCM
            {
                Codigo = nomenclaturasDto.Codigo,
                Ano_Ato = nomenclaturasDto.Ano_Ato,
                Data_Fim = nomenclaturasDto.Data_Fim,
                Data_Inicio = nomenclaturasDto.Data_Inicio,
                Descricao = nomenclaturasDto.Descricao,
                Numero_Ato = nomenclaturasDto.Numero_Ato,
                Tipo_Ato = nomenclaturasDto.Tipo_Ato,
            };

            await _ncmRepository.CreateNCMAsync(ncm);

            Nomenclaturas nomenclaturas = new Nomenclaturas
            {
                Codigo = ncm.Codigo,
                Ano_Ato = ncm.Ano_Ato,
                Data_Fim = ncm.Data_Fim,
                Data_Inicio = ncm.Data_Inicio,
                Descricao = ncm.Descricao,
                Numero_Ato = ncm.Numero_Ato,
                Tipo_Ato = ncm.Tipo_Ato,
            };
            return new Optional<Nomenclaturas>(nomenclaturas);
        }

        public async Task<IList<NCM>> GetAllAsync()
        {
            var result = await _ncmRepository.GetAllAsync();
            return result;
            List<Nomenclaturas> nomeclaturasList = new List<Nomenclaturas>();

            for (int i = 0; i < result.Count; i++)
            {
                nomeclaturasList.Add(new Nomenclaturas
                {
                    Ano_Ato = result[i].Ano_Ato,
                    Codigo = result[i].Codigo,
                    Data_Fim = result[i].Data_Fim,
                    Data_Inicio = result[i].Data_Inicio,
                    Descricao = result[i].Descricao,
                    Numero_Ato = result[i].Numero_Ato,
                    Tipo_Ato = result[i].Tipo_Ato
                });
            }
          //  return nomeclaturasList;
        }

        public class ResponseGenericException<T>
        {
            public static Dictionary<string, T> Response(T obj)
            {
                if (obj == null)
                {
                    return new Dictionary<string, T>();
                }
                return new Dictionary<string, T>
                {

                    ["result"] = obj
                };
            }
        }

        public class MinhaExcecaoPersonalizada : Exception
        {
            public MinhaExcecaoPersonalizada(string mensagem) : base(mensagem)
            {
            }
        }
        public async Task<NCM>? GetByIdAsync(string Codigo)
        {
            return await _ncmRepository.GetByIdAsync(Codigo);
        }

        public async Task RemoveAsync(string Codigo)
        {
          await  _ncmRepository.RemoveNCM(Codigo);
        }

        public async Task UpdateAsync(NCMArquivo ncmArquivoDto)
        {
           await _ncmRepository.RemoveNCMEstatisticaAsync();

            await _ncmRepository.CreateNCMEStatisticaAsync(new NCMEStatistica
            {
                Ato = ncmArquivoDto.Ato,
                Data_Ultima_Atualizacao_NCM = ncmArquivoDto.Data_Ultima_Atualizacao_NCM
            });

            foreach (var ncm in ncmArquivoDto.Nomenclaturas)
            {

                var result = await _ncmRepository.GetByIdAsync(ncm.Codigo);
                if (result != null)
                {
                    await _ncmRepository.UpdateNCMAsync(
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
                    await _ncmRepository.CreateNCMAsync(
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

          
        }

        public async Task UpdateAsync(Nomenclaturas Nomenclatura)
        {
           await  _ncmRepository.UpdateNCMAsync(
                    new NCM
                    {
                        Codigo = Nomenclatura.Codigo,
                        Ano_Ato = Nomenclatura.Ano_Ato,
                        Data_Fim = Nomenclatura.Data_Fim,
                        Data_Inicio = Nomenclatura.Data_Inicio,
                        Descricao = Nomenclatura.Descricao,
                        Numero_Ato = Nomenclatura.Numero_Ato,
                        Tipo_Ato = Nomenclatura.Tipo_Ato,
                    });

           
        }
    }
}
