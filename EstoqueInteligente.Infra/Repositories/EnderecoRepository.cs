using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;

namespace EstoqueInteligente.Infra.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly Context.EstoqueInteligenteContext _context;

        public EnderecoRepository(Context.EstoqueInteligenteContext context)
        {
            _context = context;
        }

        public async Task AlterarBairro(Bairro bairro)
        {
            _context.Update(bairro);
        }

        public async Task AlterarCidade(Cidade cidade)
        {
            _context.Update(cidade);
        }

        public async Task AlterarEndereco(Endereco endereco)
        {
            _context.Update(endereco);
        }

        public async Task<Bairro> BuscarBairro(int CodigoBairro)
        {
            return await _context.Set<Bairro>().FindAsync(CodigoBairro);
        }

        public async Task<List<Bairro>> BuscarBairro(string nomeBairro)
        {
            var resultado = _context.Set<Bairro>().Where(x=>x.NomeBairro.Contains(nomeBairro)).ToList();
           
            return resultado;
        }

        public async Task<Cidade> BuscarCidade(int codigoCidade)
        {
            return await _context.Set<Cidade>().FindAsync(codigoCidade);
        }

        public async Task<List<Cidade>> BuscarCidade(string nomeCidade)
        {
            var resultado = _context.Cidade.ToList();
            return resultado;
        }

        public async Task<Endereco> BuscarEndereco(int codigoEndereco)
        {
            return await _context.Set<Endereco>().FindAsync(codigoEndereco);
        }

        public async Task<List<Endereco>> BuscarEndereco(string nomeEndereco)
        {
            var resultado = _context.Set<Endereco>().Where(x=>x.Rua.Contains(nomeEndereco)).ToList();
            return resultado;
        }

        public async Task CadastrarBairro(Bairro bairro)
        {
          await _context.AddAsync(bairro);
        }

        public async Task CadastrarBairro(List<Bairro> bairroList)
        {
            foreach (var item in bairroList)
            {
                await _context.AddAsync(item);
            }
        }

        public async Task CadastrarCidade(Cidade cidade)
        {
            await _context.AddAsync(cidade);
        }

        public async  Task CadastrarCidade(List<Cidade> cidadeList)
        {
            foreach (var item in cidadeList)
            {
                await _context.AddAsync(item);
            }
        }

        public async Task CadastrarEndereco(Endereco endereco)
        {
            await _context.AddAsync(endereco);
        }

        public async Task CadastrarEndereco(List<Endereco> enderecoList)
        {
            foreach (var item in enderecoList)
            {
                await _context.AddAsync(item);
            }
        }

        public async Task DeletarBairro(int CodigoBairro)
        {
             _context.Remove(CodigoBairro);
        }

        public async Task DeletarCidade(int codigoCidade)
        {
            _context.Remove(codigoCidade);
        }

        public async Task DeletarEndereco(int codigoEndereco)
        {
            _context.Remove(codigoEndereco);
        }

        public void Dispose()
        {
           
        }
    }
}
