

using System.ComponentModel.DataAnnotations;

namespace EstoqueInteligente.Domain.Entities
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoCompletaProduto { get; set; }
        public string DescricaoResumidaProduto { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? RegistroMS { get; set; }
        public bool Ativo { get; set; }
        public bool Eliminado { get; set; }
        public NCM? NCM { get; set; }
        public ICollection<Grupo>? Grupo { get; set; }
        public ProdutoClasseTerapeutica? ProdutoClasseTerapeutica { get; set; }
        public virtual ProdutoCodigoBarra? ProdutoCodigoBarra { get; set; }
        public ProdutoFormula? ProdutoFormula { get; set; }
        public ICollection<Imagem> Imagem { get; set; } = new List<Imagem>();
        public ProdutoEstoque ProdutoEstoque { get; set; }


        public Produto() { }
        public Produto(
            string NomeProduto, 
            string DescricaoCompletaProduto, 
            string DescricaoResumidaProduto,
            DateTime DataCadastro,
            string RegistroMS,
            NCM NCM,
            ICollection<Grupo> ProdutoGrupo,
            ProdutoClasseTerapeutica ProdutoClasseTerapeutica,
            ICollection<ProdutoCodigoBarra> ProdutoCodigoBarra,
            ProdutoFormula ProdutoFormula,
            ICollection<Imagem> ProdutoImagem,
            ProdutoEstoque ProdutoEstoque,
            bool Ativo
            )
        { }

    } 
    public class ProdutoEstoquePrecificacao
    {
        public int CodigoEstoquePrecificacao { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoIncentivo { get; set; }
        public double PrecoCustoMedio { get; set; }
        public int Markup { get; set; }
        public int CodigoProdutoEstoque { get; set; }
        public ProdutoEstoque ProdutoEstoque { get; set; }
    }
    public class ProdutoEstoqueControle
    {
        public int CodigoEstoqueControle { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public Char CurvaABC { get; set; }
        public int EstoqueDemanda { get; set; }
        public int EstoqueDemandaMinima { get; set; }
        public int EstoqueDemandaMaxima { get; set; }
        public DateTime DataCurvaAplicada { get; set; }
        public int CodigoProdutoEstoque { get; set; }
        public ProdutoEstoque ProdutoEstoque { get; set; }
        public int CodigoProdutoEmbalagem { get; set; }
        public ProdutoEmbalagem ProdutoEmbalagem { get; set; }

    }
    public class ProdutoEstoqueLote
    {
        public int CodigoEstoqueLote { get; set; }
        public string Lote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Estoque { get; set; }
        public int CodigoProdutoEstoque { get; set; }
        public ProdutoEstoque ProdutoEstoque { get; set; }
    }
    public class ProdutoEstatistica
    {
        public int CodigoEstatistica { get; set; }
        public DateTime UltimaCompra { get; set; }
        public DateTime UltimaVenda { get; set; }
        public double PrecoUltimaCompra { get; set; }
        public double PrecoUltimaVenda { get; set; }
        public int CodigoProdutoEstoque { get; set; }

        public ProdutoEstoque ProdutoEstoque { get; set; }
    }
    public class ProdutoEstoque
    {
        public int CodigoEstoque { get; set; }
        public int CodigoConfiguracaoEmpresa { get; set; }
        public ConfiguracaoEmpresa ConfiguracaoEmpresa { get; set; }
        public int Estoque { get; set; }
        public int CodigoProduto { get; set; }
        
        public Produto Produto { get; set; }
        public ProdutoEstatistica ProdutoEstatistica { get; set; }
        public ProdutoEstoqueLote ProdutoEstoqueLote { get; set; }
        public ProdutoEstoqueControle ProdutoEstoqueControle { get; set; }
        public ProdutoEstoquePrecificacao ProdutoEstoquePrecificacao { get; set; }

    }
    public class ProdutoClasseTerapeutica
    {
        public int? CodigoClasseTerapeutica { get; set; }
        public string NomeClasseTerapeutica { get; set; }
        public ICollection<Produto> Produto { get; set; }

        public ProdutoClasseTerapeutica() { }
        public ProdutoClasseTerapeutica(
            int CodigoClasseTerapeutica,
            string NomeClasseTerapeutica)
        {
            this.CodigoClasseTerapeutica = CodigoClasseTerapeutica;
            this.NomeClasseTerapeutica = NomeClasseTerapeutica;
        }
    }
    public class ProdutoFormula
    {
        public int CodigoFurmula { get; set; }
        public string NomeFormula { get; set; }
        public ICollection<Produto> Produto { get; set; }
        public ICollection<Substancia> Substancias { get; set; }
    }
    public class Substancia
    {
        public int CodigoSubstancia { get; set; }
        public string NomeSubstancia { get; set; }
        public ICollection<ProdutoFormula> ProdutoFormula { get; set; }
    }
    public class ProdutoFormulaSubstancia
    {
      public int CodigoSubstancia { get;set; }
      public int CodigoFormula { get;set; }
    }
    public class ProdutoCodigoBarra
    {
        public int CodigoBarra { get; set; }
        public string GTIN { get; set; }
        public int CodigoProduto { get; set; }
        public virtual Produto Produto { get; set; }
    }
    public class Imagem
    {
        public int CodigoImagem { get; set; }
        public byte[] EnderecoImagem { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
    public class Grupo
    {
        public int CodigoGrupo { get; set; }
        public string NomeGrupo { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public bool Unico { get; set; }

        public Grupo() { }
        public Grupo(
            int CodigoGrupo,
            string NomeGrupo,
            bool Unico) 
        {
            this.CodigoGrupo = CodigoGrupo;
            this.NomeGrupo = NomeGrupo;
            this.Unico = Unico;
        }

    }
    public class ProdutoEmbalagem
    {
        public int CodigoEmbalagem { get; set; }
        public string DescricaoEmbalagem { get; set; }
        public string SiglaEmbalagem { get; set; }
        public int QuantidadePorEmbalagem { get; set; }
        public ProdutoEstoqueControle ProdutoEstoqueControle { get; set; }
    }
    public class NCM
    {
        public string Codigo { get; set; }
        public string Ano_Ato { get; set; } = string.Empty;
        public string Data_Fim { get; set; } = string.Empty;
        public string Data_Inicio { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Numero_Ato { get; set; } = string.Empty;
        public string Tipo_Ato { get; set; } = string.Empty;

        public virtual ICollection<Produto> Produtos { get; set; }

        public NCM() { }
        public NCM(
            string Codigo,
            string Ano_Ato, 
            string Data_Fim,
            string Data_Inicio,
            string Descricao,
            string Numero_Ato,
            string Tipo_Ato) 
        {
            this.Codigo = Codigo;
            this.Ano_Ato = Ano_Ato;
            this.Data_Fim = Data_Fim;
            this.Data_Inicio = Data_Inicio;
            this.Descricao = Descricao;
            this.Numero_Ato = Numero_Ato;
            this.Tipo_Ato = Tipo_Ato;
        }
    }
    public class NCMEStatistica
    {
        public int CodigoNCMEstatistica { get; set; }
        public string Ato { get; set; }
        public string Data_Ultima_Atualizacao_NCM { get; set; }
    }
    public class Pessoa
    {
        public int CodigoPessoa { get; set; }

        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
    }
    public class PessoaFisica
    {
        public int CodigoPessoaFisica { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeSocial { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string RGOrgao { get; set; }
        public string RGOrgaoUF { get; set; }
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Sexo Sexo { get; set; }
        public int CodigoPessoa { get; set; }
        public Pessoa Pessoa { get; set; }


        public bool UtilizaNomeSocial { get; set; }
        public bool Ativo { get; set; }
        public bool Eliminado { get; set; }
    }
    public class PessoaJuridica
    {
        public int CodigoPessoaJuridica{ get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string IE { get;set; }
        public string CNAE { get; set; }
        public DateTime DataCadastro { get; set; }
        public int CodigoPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
        public ConfiguracaoEmpresa ConfiguracaoEmpresa { get; set; }

    }
    public class Endereco
    {
        public int CodigoEndereco { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public int CodigoCidade { get; set; }
        public Cidade Cidade { get; set; }
        public int CodigoBairro { get; set; }
        public Bairro Bairro { get; set; }
        public string Complemento { get; set; }
        public int CodigoPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
    public class Cidade
    {
        public int CodigoCidade { get; set; }
        public string NomeCidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string CodigoIBGE { get; set; }
        public Endereco Endereco { get; set; }
    }
    public class Bairro
    {
        public int CodigoBairro { get; set; }
        public string NomeBairro { get; set; }
        public Endereco Endereco { get; set; }
    }
    public enum  Sexo
    {
        Masculino, Feminino, Outro
    }
    public class Contato
    {
        public int CodigoContato { get; set; }
        public string DescricaoContato { get; set; }
        public int CodigoContatoTipo { get;set; }
        public ContatoTipo ContatoTipo { get; set; }
        public int CodigoPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
    public class ContatoTipo
    {
        public int CodigoContatoTipo { get; set; }
        public string NomeContato { get; set; }
        public Contato Contato { get; set; } 
    }
    public class ConfiguracaoEmpresa
    {
        public int CodigoEmpresa { get; set; }
        public int CodigoPessoaJuridica { get; set; }
        public string NomeFilial { get; set; }
        public bool Ativo { get; set; }
        public ProdutoEstoque ProdutoEstoque { get; set;}
        public PessoaJuridica PessoaJuridica { get; set; }

    }
}
