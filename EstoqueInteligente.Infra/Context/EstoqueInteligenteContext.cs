using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EstoqueInteligente.Domain.Entities.Identity;
using EstoqueInteligente.Infra.Mappings;
using EstoqueInteligente.Domain.Entities;

namespace EstoqueInteligente.Infra.Context
{
    public class EstoqueInteligenteContext : IdentityDbContext<User, Role, int
         , IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>
        , IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public EstoqueInteligenteContext() { }

        public EstoqueInteligenteContext(DbContextOptions<EstoqueInteligenteContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region AplyConfiguration
            modelBuilder.ApplyConfiguration(new BairroMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new ConfiguracaoEmpresaMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new ContatoTipoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new NCMMap());
            modelBuilder.ApplyConfiguration(new NCMEstatisticaMap());
            modelBuilder.ApplyConfiguration(new PessoaFisicaMap());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ProdutoClasseTerapeuticaMap());
            modelBuilder.ApplyConfiguration(new ProdutoCodigoBarraMap());
            modelBuilder.ApplyConfiguration(new ProdutoEmbalagemMap());
            modelBuilder.ApplyConfiguration(new ProdutoEstatisticaMap());
            modelBuilder.ApplyConfiguration(new ProdutoEstoqueControleMap());
            modelBuilder.ApplyConfiguration(new ProdutoEstoqueLoteMap());
            modelBuilder.ApplyConfiguration(new ProdutoEstoqueMap());
            modelBuilder.ApplyConfiguration(new ProdutoEstoquePrecificacaoMap());
            modelBuilder.ApplyConfiguration(new FormulaMap());
            modelBuilder.ApplyConfiguration(new FormulaSubstanciaMap());
            modelBuilder.ApplyConfiguration(new GrupoMap());
            modelBuilder.ApplyConfiguration(new ImagemMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new SubstanciaMap());
            #endregion
            #region Identity 
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<UserRole>().HasOne<User>(u => u.User)
                .WithMany(ur => ur.UserRoles).HasForeignKey(ur => ur.UserId);
            modelBuilder.Entity<UserRole>().HasOne(u => u.Role)
                .WithMany(ur => ur.UserRoles).HasForeignKey(ur => ur.RoleId);

            modelBuilder.Entity<Organizacao>(org =>
            {
                org.ToTable("Organizacoes");
                org.HasKey(x => x.CodigoOrganizacao);

                org.HasMany<User>()
                    .WithOne()
                    .HasForeignKey(x => x.CodigoOrganizacao)
                    .IsRequired(false);
            });

            #endregion
            #region Seed
            modelBuilder.Entity<Cidade>().HasData(
                new Cidade
                {
                    CodigoCidade = 1,
                    CEP = "15760000",
                    CodigoIBGE = "3555802",
                    NomeCidade = "Urania",
                    UF = "SP"
                });
            modelBuilder.Entity<Bairro>().HasData(
                new Bairro
                {
                    CodigoBairro = 1,
                    NomeBairro = "Centro"
                });

            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa
                {
                    CodigoPessoa = 1
                });
            modelBuilder.Entity<PessoaFisica>().HasData(
             new PessoaFisica
             {
                 CodigoPessoaFisica = 1,
                 CodigoPessoa = 1,
                 CPF = "69850578025",
                 DataCadastro = DateTime.Now,
                 DataNascimento = Convert.ToDateTime("10/08/2023"),
                 Nome = "Jeferson",
                 NomeCompleto = "Jeferson Willian do prado martins",
                 NomeSocial = "",
                 RG = "402287897",
                 RGOrgao = "SSP",
                 RGOrgaoUF = "SP",
                 Sexo = Sexo.Masculino,
                 UtilizaNomeSocial = false,
                 Eliminado = false,
                 Ativo = true
             });
            modelBuilder.Entity<ContatoTipo>().HasData(
                new ContatoTipo
                {
                    CodigoContatoTipo = 1,
                    NomeContato = "Whatsapp"
                });
            modelBuilder.Entity<Contato>()
              .HasData(new Contato
              {
                  CodigoContato = 1,
                  CodigoContatoTipo = 1,
                  DescricaoContato = "17988414859",
                  CodigoPessoa = 1
              });
            modelBuilder.Entity<PessoaJuridica>().HasData(
                new PessoaJuridica
                {
                    CodigoPessoaJuridica = 1,
                    CNPJ = "47473617000198",
                    IE = "683462917135",
                    CNAE = "7518",
                    RazaoSocial = "Razão Social Empresa LTDA",
                    DataCadastro = DateTime.Now,
                    NomeFantasia = "Nome Fantasia empresa LDTA",
                    CodigoPessoa = 1

                });
            modelBuilder.Entity<ConfiguracaoEmpresa>().HasData(
                new ConfiguracaoEmpresa
                {
                    CodigoEmpresa = 1,
                    NomeFilial = "Empresa Teste",
                    Ativo = true,
                    CodigoPessoaJuridica = 1
                });
            modelBuilder.Entity<Endereco>().HasData(
                new List<Endereco> { new Endereco {
                CodigoBairro = 1 ,
                CodigoEndereco = 1,
                Numero = "1822",
                CodigoCidade = 1,
                Complemento = "Perdo da casa da maria",
                Rua = "Rua santa maria",
                CodigoPessoa =1
                
                }
                }) ;
            modelBuilder.Entity<Grupo>().HasData(
                new Grupo
                {
                    CodigoGrupo = 1,
                    NomeGrupo = "Generico",
                    Unico = true
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    CodigoProduto = 1,
                    DataCadastro = DateTime.Now,
                    Ativo = true,
                    DescricaoCompletaProduto = "Descricao completa do produto",
                    DescricaoResumidaProduto = "Descricao Resumida do produto",
                    Eliminado = false,
                    NomeProduto = "Nome do produto"
                }
                );
            modelBuilder.Entity<ProdutoEstoque>().HasData(new ProdutoEstoque
            {
                CodigoEstoque = 1,
                CodigoConfiguracaoEmpresa = 1 ,
                Estoque = 10,
                CodigoProduto = 1 
            });
            modelBuilder.Entity<ProdutoClasseTerapeutica>().HasData(
                new ProdutoClasseTerapeutica { CodigoClasseTerapeutica = 1, NomeClasseTerapeutica = "Antimicrobiano" },
                new ProdutoClasseTerapeutica { CodigoClasseTerapeutica = 2, NomeClasseTerapeutica = "Psicotropico" }
                );
            modelBuilder.Entity<ProdutoCodigoBarra>().HasData(new ProdutoCodigoBarra
            {
                CodigoBarra = 1,
                GTIN = "788848488484848",
                CodigoProduto = 1

            }) ;
            modelBuilder.Entity<ProdutoEmbalagem>().HasData(new ProdutoEmbalagem
            {
                CodigoEmbalagem = 1,
                DescricaoEmbalagem = "Unidade",
                QuantidadePorEmbalagem = 1,
                SiglaEmbalagem = "UN"
            });
            modelBuilder.Entity<ProdutoEstatistica>().HasData(
                new ProdutoEstatistica
                {
                    CodigoEstatistica = 1,
                    PrecoUltimaCompra = 16.22,
                    PrecoUltimaVenda = 32.22,
                    UltimaCompra = DateTime.Now,
                    UltimaVenda = DateTime.Now,
                    CodigoProdutoEstoque = 1
                }) ;
            modelBuilder.Entity<ProdutoEstoqueControle>().HasData(
                new ProdutoEstoqueControle
                {
                    CodigoEstoqueControle = 1,
                    DataCurvaAplicada = DateTime.Now,
                    CurvaABC = 'A',
                    EstoqueDemanda = 58,
                    EstoqueDemandaMaxima = 78,
                    EstoqueDemandaMinima = 38,
                    CodigoProdutoEstoque = 1 ,
                    CodigoProdutoEmbalagem = 1
                });
            modelBuilder.Entity<ProdutoEstoquePrecificacao>().HasData(
                new ProdutoEstoquePrecificacao
                {
                    CodigoEstoquePrecificacao = 1,
                    CodigoProdutoEstoque = 1 ,
                    Markup = 120,
                    PrecoCompra = 16.22,
                    PrecoCusto = 19.23,
                    PrecoCustoMedio = 20.11
                });

            modelBuilder.Entity<NCM>().HasData(
                new NCM
                {
                    Ano_Ato = "2021",
                    Codigo = "01",
                    Data_Fim = "31/12/9999",
                    Data_Inicio = "01/04/2022",
                    Descricao = "Animais vivos",
                    Numero_Ato = "000272",
                    Tipo_Ato = "Res Camex"
                });
            modelBuilder.Entity<NCMEStatistica>().HasData(
                new NCMEStatistica
                {
                    CodigoNCMEstatistica = 1,
                    Ato = "Resolução Camex nº 440/2022",
                    Data_Ultima_Atualizacao_NCM = "01/04/2023"
                });

            modelBuilder.Entity<Substancia>().HasData(
            new Substancia { CodigoSubstancia = 1, NomeSubstancia = "Dipirona Sodica" },
            new Substancia { CodigoSubstancia = 2, NomeSubstancia = "Lozartana" },
            new Substancia { CodigoSubstancia = 3, NomeSubstancia = "Lizina" },
            new Substancia { CodigoSubstancia = 4, NomeSubstancia = "Midazolam" },
            new Substancia { CodigoSubstancia = 5, NomeSubstancia = "Morfina" }
            );
            #endregion
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JEFERSON\\SQLDEV;Database=EstoqueInteligente;User Id=sa;Password=123456;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
        #region DbSet
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<ConfiguracaoEmpresa> ConfiguracaoEmpresa { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<ContatoTipo> ContatoTipo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<NCM> NCM { get; set; }
        public DbSet<NCMEStatistica> NCMEStatistica { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<ProdutoClasseTerapeutica> ProdutoClasseTerapeutica { get; set; }
        public DbSet<ProdutoCodigoBarra> ProdutoCodigoBarra { get; set; }
        public DbSet<ProdutoEmbalagem> ProdutoEmbalagem { get; set; }
        public DbSet<ProdutoEstatistica> ProdutoEstatistica { get; set; }
        public DbSet<ProdutoEstoqueControle> ProdutoEstoqueControle { get; set; }
        public DbSet<ProdutoEstoqueLote> ProdutoEstoqueLote { get; set; }
        public DbSet<ProdutoEstoque> ProdutoEstoque { get; set; }
        public DbSet<ProdutoEstoquePrecificacao> ProdutoEstoquePrecificacao { get; set; }
        public DbSet<Formula> Formula { get; set; }
        public DbSet<Substancia> Substancia { get; set; }
        public DbSet<FormulaSubstancia> FormulaSubstancia { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Produto> Produto { get; set; }
      
        #endregion
    }
}
