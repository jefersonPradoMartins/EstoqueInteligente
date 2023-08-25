using EstoqueInteligente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueInteligente.Service.DTO
{
    public record ProdutoDto()
    {
        public string NomeProduto { get; set; }
        public string DescricaoCompletaProduto { get; set; }
        public string DescricaoResumidaProduto { get; set; }
        public string? RegistroMS { get; set; }
        public string? NCM { get; set; }
        public bool Ativo { get; set; }
        public int CodigoConfiguracaoEmpresa { get; set; }
        #region Produto_Grupo
        public ICollection<ProdutoGrupoDto>? ProdutoGrupoDto { get; set; }
        #endregion
        #region Produto_Classeterapeutica
        public int? ProdutoClasseTerapeutica { get; set; }
        #endregion
        #region Produto_Codigo_Barra
        public virtual ICollection<ProdutoCodigoBarraDto>? ProdutoCodigoBarraDto { get; set; }
        #endregion
        #region Produto_Formula
        public FormulaDto ProdutoFormulaDto { get; set; }
        #endregion
        #region Produto_Imagem
        public ProdutoImagemDto ProdutoImagemDto { get; set; }

        #endregion
        #region Produto_Estoque
        public ProdutoEstoqueDto ProdutoEstoqueDto { get; set; }
        #endregion
        #region Produto_Estoque_Lote
        public ProdutoEstoqueLoteDto ProdutoEstoqueLoteDto { get; set; }
        #endregion
        #region Produto_Estoque_Controle
        public ProdutoEstoqueControleDto ProdutoEstoqueControleDto { get; set; }
        #endregion
        #region Produto_Estoque_Precificacao
        public ProdutoEstoquePrecificaoDto ProdutoEstoquePrecificaoDto { get; set; }
        #endregion
        
    }
  
    public record ProdutoImagemDto
    {
        public ICollection<string> ProdutoImagem { get; set; }

        public ProdutoImagemDto(ICollection<string> ProdutoImagem)
        {
            this.ProdutoImagem = ProdutoImagem;
        }
    }
    public record ProdutoEstoqueDto
    {
        public int Estoque { get; set; }

        public ProdutoEstoqueDto(int Estoque)
        {
            this.Estoque = Estoque;
        }
    }
    public record ProdutoEstoqueLoteDto
    {
        public string Lote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int EstoqueLote { get; set; }

        public ProdutoEstoqueLoteDto(
            string Lote,
            DateTime DataFabricacao,
            DateTime DataVencimento,
            int EstoqueLote)
        {
            this.Lote = Lote;
            this.DataFabricacao = DataFabricacao;
            this.DataVencimento = DataVencimento;
            this.EstoqueLote = EstoqueLote;
        }
    }
    public record ProdutoEstoqueControleDto
    {
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public Char CurvaABC { get; set; }
        public int EstoqueDemanda { get; set; }
        public int EstoqueDemandaMinima { get; set; }
        public int EstoqueDemandaMaxima { get; set; }
        public DateTime DataCurvaAplicada { get; set; }
        public int CodigoProdutoEmbalagem { get; set; }

        public ProdutoEstoqueControleDto(
            int EstoqueMinimo,
            int EstoqueMaximo,
            char CurvaABC,
            int EstoqueDemanda,
            int EstoqueDemandaMinima,
            int EstoqueDemandaMaxima,
            DateTime DataCurvaAplicada,
            int CodigoProdutoEmbalagem)
        {
            this.EstoqueMinimo = EstoqueMinimo;
            this.EstoqueMaximo = EstoqueMaximo;
            this.CurvaABC = CurvaABC;
            this.EstoqueDemanda = EstoqueDemanda;
            this.EstoqueDemandaMinima = EstoqueDemandaMinima;
            this.EstoqueDemandaMaxima = EstoqueDemandaMaxima;
            this.DataCurvaAplicada = DataCurvaAplicada;
            this.CodigoProdutoEmbalagem = CodigoProdutoEmbalagem;
        }
    }
    public record ProdutoEstoquePrecificaoDto
    {
        public double PrecoCompra { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoIncentivo { get; set; }
        public double PrecoCustoMedio { get; set; }
        public int Markup { get; set; }

        public ProdutoEstoquePrecificaoDto(
            double PrecoCompra,
            double PrecoCusto,
            double PrecoIncentivo,
            double PrecoCustoMedio,
            int Markup)
        {
            this.PrecoCompra = PrecoCompra;
            this.PrecoCusto = PrecoCusto;
            this.PrecoIncentivo = PrecoIncentivo;
            this.PrecoCustoMedio = PrecoCustoMedio;
            this.Markup = Markup;
        }
    }

    public record ProdutoCodigoBarraDto
    {
        public int CodigoBarra { get; set; }
        public string GTIN { get; set; }
        public int CodigoProduto { get; set; }

        public ProdutoCodigoBarraDto(int codigoBarra, string GTIN, int CodigoProduto)
        {
            this.CodigoBarra = codigoBarra;
            this.GTIN = GTIN;
            this.CodigoProduto = CodigoProduto;
        }
    }

    public record ProdutoGrupoDto
    {
        public int CodigoGrupo { get; set; }
        public string NomeGrupo { get; set; }
        public bool Unico { get; set; }

        public ProdutoGrupoDto(int CodigoGrupo, string NomeGrupo, bool Unico)
        {
            this.CodigoGrupo = CodigoGrupo;
            this.NomeGrupo = NomeGrupo;
            this.Unico = Unico;
        }
    }
}
