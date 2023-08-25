using EstoqueInteligente.Core.Structs;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;

namespace EstoqueInteligente.Service.Service
{
    public class SubstanciaService : ISubstanciaService
    {
        private readonly ISubstanciaRepository _substanciaRepository;

        public SubstanciaService(ISubstanciaRepository substanciaRepository)
        {
            _substanciaRepository = substanciaRepository;
        }

        public Task<Optional<SubstanciaDto>> CreateAsync(SubstanciaDto substanciaDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<SubstanciaDto>> GetAllAsync()
        {
            var result = await _substanciaRepository.GetAll();
            List<SubstanciaDto> substanciaDtos = new List<SubstanciaDto>();
            foreach (var substancia in result)
            {
                substanciaDtos.Add(new SubstanciaDto
                {
                    CodigoSubstancia = substancia.CodigoSubstancia,
                    NomeSubstancia = substancia.NomeSubstancia
                });
            }

            return substanciaDtos;
        }

        public Task<Optional<SubstanciaDto>> GetByIdAsync(string Codigo)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string Codigo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SubstanciaDto substanciaDto)
        {
            throw new NotImplementedException();
        }
    }
}
