using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Infra.Interfaces.Repository
{
    public interface IEnderecoRepository : IDisposable
    {
        #region Cidade
        Task CadastrarCidade(Cidade cidade);
        Task CadastrarCidade(List<Cidade> cidadeList);
        Task DeletarCidade(int codigoCidade);
        Task<Cidade> BuscarCidade(int codigoCidade);
        Task<List<Cidade>> BuscarCidade(string nomeCidade);
        Task AlterarCidade(Cidade cidade);
        #endregion
        #region Bairro
        Task CadastrarBairro(Bairro bairro);
        Task CadastrarBairro(List<Bairro> bairroList);
        Task DeletarBairro(int CodigoBairro);
        Task<Bairro> BuscarBairro(int CodigoBairro);
        Task<List<Bairro>> BuscarBairro(string nomeBairro);
        Task AlterarBairro(Bairro bairro);
        #endregion
        #region Endereco
        Task CadastrarEndereco(Endereco endereco);
        Task CadastrarEndereco(List<Endereco> enderecoList);
        Task DeletarEndereco(int codigoEndereco);
        Task<Endereco> BuscarEndereco(int codigoEndereco);
        Task<List<Endereco>> BuscarEndereco(string nomeEndereco);
        Task AlterarEndereco(Endereco endereco);
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
