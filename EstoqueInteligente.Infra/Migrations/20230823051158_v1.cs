using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstoqueInteligente.Infra.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    CodigoBairro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeBairro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.CodigoBairro);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    CodigoCidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "char(2)", nullable: false),
                    CodigoIBGE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.CodigoCidade);
                });

            migrationBuilder.CreateTable(
                name: "Contato_Tipo",
                columns: table => new
                {
                    CodigoContatoTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeContato = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato_Tipo", x => x.CodigoContatoTipo);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    CodigoGrupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeGrupo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unico = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.CodigoGrupo);
                });

            migrationBuilder.CreateTable(
                name: "Imagem",
                columns: table => new
                {
                    CodigoImagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoImagem = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagem", x => x.CodigoImagem);
                });

            migrationBuilder.CreateTable(
                name: "NCM",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ano_Ato = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Data_Fim = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Data_Inicio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Ato = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Tipo_Ato = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCM", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "NCM_Estatistica",
                columns: table => new
                {
                    CodigoNCMEstatistica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ato = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Data_Ultima_Atualizacao_NCM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCM_Estatistica", x => x.CodigoNCMEstatistica);
                });

            migrationBuilder.CreateTable(
                name: "Organizacoes",
                columns: table => new
                {
                    CodigoOrganizacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeOrganizacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizacoes", x => x.CodigoOrganizacao);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    CodigoPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.CodigoPessoa);
                });

            migrationBuilder.CreateTable(
                name: "Produto_ClasseTerapeutica",
                columns: table => new
                {
                    CodigoClasseTerapeutica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeClasseTerapeutica = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_ClasseTerapeutica", x => x.CodigoClasseTerapeutica);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Embalagem",
                columns: table => new
                {
                    CodigoEmbalagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoEmbalagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiglaEmbalagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadePorEmbalagem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Embalagem", x => x.CodigoEmbalagem);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Formula",
                columns: table => new
                {
                    CodigoFurmula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFormula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Formula", x => x.CodigoFurmula);
                });

            migrationBuilder.CreateTable(
                name: "Substancia",
                columns: table => new
                {
                    CodigoSubstancia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSubstancia = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substancia", x => x.CodigoSubstancia);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoOrganizacao = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Organizacoes_CodigoOrganizacao",
                        column: x => x.CodigoOrganizacao,
                        principalTable: "Organizacoes",
                        principalColumn: "CodigoOrganizacao");
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    CodigoContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoContato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoContatoTipo = table.Column<int>(type: "int", nullable: false),
                    CodigoPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.CodigoContato);
                    table.ForeignKey(
                        name: "FK_Contato_Contato_Tipo_CodigoContatoTipo",
                        column: x => x.CodigoContatoTipo,
                        principalTable: "Contato_Tipo",
                        principalColumn: "CodigoContatoTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_CodigoPessoa",
                        column: x => x.CodigoPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "CodigoPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    CodigoEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoCidade = table.Column<int>(type: "int", nullable: false),
                    CodigoBairro = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.CodigoEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Bairro_CodigoBairro",
                        column: x => x.CodigoBairro,
                        principalTable: "Bairro",
                        principalColumn: "CodigoBairro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_CodigoCidade",
                        column: x => x.CodigoCidade,
                        principalTable: "Cidade",
                        principalColumn: "CodigoCidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoa_CodigoPessoa",
                        column: x => x.CodigoPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "CodigoPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa_Fisica",
                columns: table => new
                {
                    CodigoPessoaFisica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RGOrgao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RGOrgaoUF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    CodigoPessoa = table.Column<int>(type: "int", nullable: false),
                    UtilizaNomeSocial = table.Column<bool>(type: "bit", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa_Fisica", x => x.CodigoPessoaFisica);
                    table.ForeignKey(
                        name: "FK_Pessoa_Fisica_Pessoa_CodigoPessoa",
                        column: x => x.CodigoPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "CodigoPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa_Juridica",
                columns: table => new
                {
                    CodigoPessoaJuridica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNAE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoPessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa_Juridica", x => x.CodigoPessoaJuridica);
                    table.ForeignKey(
                        name: "FK_Pessoa_Juridica_Pessoa_CodigoPessoa",
                        column: x => x.CodigoPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "CodigoPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    CodigoProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DescricaoCompletaProduto = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DescricaoResumidaProduto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistroMS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    NCMCodigo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProdutoClasseTerapeuticaCodigoClasseTerapeutica = table.Column<int>(type: "int", nullable: true),
                    ProdutoFormulaCodigoFurmula = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.CodigoProduto);
                    table.ForeignKey(
                        name: "FK_Produto_NCM_NCMCodigo",
                        column: x => x.NCMCodigo,
                        principalTable: "NCM",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_Produto_Produto_ClasseTerapeutica_ProdutoClasseTerapeuticaCodigoClasseTerapeutica",
                        column: x => x.ProdutoClasseTerapeuticaCodigoClasseTerapeutica,
                        principalTable: "Produto_ClasseTerapeutica",
                        principalColumn: "CodigoClasseTerapeutica");
                    table.ForeignKey(
                        name: "FK_Produto_Produto_Formula_ProdutoFormulaCodigoFurmula",
                        column: x => x.ProdutoFormulaCodigoFurmula,
                        principalTable: "Produto_Formula",
                        principalColumn: "CodigoFurmula");
                });

            migrationBuilder.CreateTable(
                name: "Produto_Formula_substancia",
                columns: table => new
                {
                    CodigoSubstancia = table.Column<int>(type: "int", nullable: false),
                    CodigoFormula = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Formula_substancia", x => new { x.CodigoFormula, x.CodigoSubstancia });
                    table.ForeignKey(
                        name: "FK_Produto_Formula_substancia_Produto_Formula_CodigoFormula",
                        column: x => x.CodigoFormula,
                        principalTable: "Produto_Formula",
                        principalColumn: "CodigoFurmula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Formula_substancia_Substancia_CodigoSubstancia",
                        column: x => x.CodigoSubstancia,
                        principalTable: "Substancia",
                        principalColumn: "CodigoSubstancia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracaoEmpresa",
                columns: table => new
                {
                    CodigoEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPessoaJuridica = table.Column<int>(type: "int", nullable: false),
                    NomeFilial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracaoEmpresa", x => x.CodigoEmpresa);
                    table.ForeignKey(
                        name: "FK_ConfiguracaoEmpresa_Pessoa_Juridica_CodigoPessoaJuridica",
                        column: x => x.CodigoPessoaJuridica,
                        principalTable: "Pessoa_Juridica",
                        principalColumn: "CodigoPessoaJuridica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_CodigoBarra",
                columns: table => new
                {
                    CodigoBarra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_CodigoBarra", x => x.CodigoBarra);
                    table.ForeignKey(
                        name: "FK_Produto_CodigoBarra_Produto_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produto",
                        principalColumn: "CodigoProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Grupo",
                columns: table => new
                {
                    GrupoCodigoGrupo = table.Column<int>(type: "int", nullable: false),
                    ProdutosCodigoProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Grupo", x => new { x.GrupoCodigoGrupo, x.ProdutosCodigoProduto });
                    table.ForeignKey(
                        name: "FK_Produto_Grupo_Grupo_GrupoCodigoGrupo",
                        column: x => x.GrupoCodigoGrupo,
                        principalTable: "Grupo",
                        principalColumn: "CodigoGrupo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Grupo_Produto_ProdutosCodigoProduto",
                        column: x => x.ProdutosCodigoProduto,
                        principalTable: "Produto",
                        principalColumn: "CodigoProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Imagem",
                columns: table => new
                {
                    ImagemCodigoImagem = table.Column<int>(type: "int", nullable: false),
                    ProdutoCodigoProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Imagem", x => new { x.ImagemCodigoImagem, x.ProdutoCodigoProduto });
                    table.ForeignKey(
                        name: "FK_Produto_Imagem_Imagem_ImagemCodigoImagem",
                        column: x => x.ImagemCodigoImagem,
                        principalTable: "Imagem",
                        principalColumn: "CodigoImagem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Imagem_Produto_ProdutoCodigoProduto",
                        column: x => x.ProdutoCodigoProduto,
                        principalTable: "Produto",
                        principalColumn: "CodigoProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Estoque",
                columns: table => new
                {
                    CodigoEstoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoConfiguracaoEmpresa = table.Column<int>(type: "int", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    CodigoProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Estoque", x => x.CodigoEstoque);
                    table.ForeignKey(
                        name: "FK_Produto_Estoque_ConfiguracaoEmpresa_CodigoConfiguracaoEmpresa",
                        column: x => x.CodigoConfiguracaoEmpresa,
                        principalTable: "ConfiguracaoEmpresa",
                        principalColumn: "CodigoEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Estoque_Produto_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produto",
                        principalColumn: "CodigoProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Estatistica",
                columns: table => new
                {
                    CodigoEstatistica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UltimaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrecoUltimaCompra = table.Column<double>(type: "float", nullable: false),
                    PrecoUltimaVenda = table.Column<double>(type: "float", nullable: false),
                    CodigoProdutoEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Estatistica", x => x.CodigoEstatistica);
                    table.ForeignKey(
                        name: "FK_Produto_Estatistica_Produto_Estoque_CodigoProdutoEstoque",
                        column: x => x.CodigoProdutoEstoque,
                        principalTable: "Produto_Estoque",
                        principalColumn: "CodigoEstoque",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_EstoqueControle",
                columns: table => new
                {
                    CodigoEstoqueControle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    CurvaABC = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EstoqueDemanda = table.Column<int>(type: "int", nullable: false),
                    EstoqueDemandaMinima = table.Column<int>(type: "int", nullable: false),
                    EstoqueDemandaMaxima = table.Column<int>(type: "int", nullable: false),
                    DataCurvaAplicada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoProdutoEstoque = table.Column<int>(type: "int", nullable: false),
                    CodigoProdutoEmbalagem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_EstoqueControle", x => x.CodigoEstoqueControle);
                    table.ForeignKey(
                        name: "FK_Produto_EstoqueControle_Produto_Embalagem_CodigoProdutoEmbalagem",
                        column: x => x.CodigoProdutoEmbalagem,
                        principalTable: "Produto_Embalagem",
                        principalColumn: "CodigoEmbalagem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_EstoqueControle_Produto_Estoque_CodigoProdutoEstoque",
                        column: x => x.CodigoProdutoEstoque,
                        principalTable: "Produto_Estoque",
                        principalColumn: "CodigoEstoque",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_EstoqueLote",
                columns: table => new
                {
                    CodigoEstoqueLote = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    CodigoProdutoEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_EstoqueLote", x => x.CodigoEstoqueLote);
                    table.ForeignKey(
                        name: "FK_Produto_EstoqueLote_Produto_Estoque_CodigoProdutoEstoque",
                        column: x => x.CodigoProdutoEstoque,
                        principalTable: "Produto_Estoque",
                        principalColumn: "CodigoEstoque",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto_EstoquePrecificacao",
                columns: table => new
                {
                    CodigoEstoquePrecificacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecoCompra = table.Column<double>(type: "float", nullable: false),
                    PrecoCusto = table.Column<double>(type: "float", nullable: false),
                    PrecoIncentivo = table.Column<double>(type: "float", nullable: false),
                    PrecoCustoMedio = table.Column<double>(type: "float", nullable: false),
                    Markup = table.Column<int>(type: "int", nullable: false),
                    CodigoProdutoEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_EstoquePrecificacao", x => x.CodigoEstoquePrecificacao);
                    table.ForeignKey(
                        name: "FK_Produto_EstoquePrecificacao_Produto_Estoque_CodigoProdutoEstoque",
                        column: x => x.CodigoProdutoEstoque,
                        principalTable: "Produto_Estoque",
                        principalColumn: "CodigoEstoque",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bairro",
                columns: new[] { "CodigoBairro", "NomeBairro" },
                values: new object[] { 1, "Centro" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "CodigoCidade", "CEP", "CodigoIBGE", "NomeCidade", "UF" },
                values: new object[] { 1, "15760000", "3555802", "Urania", "SP" });

            migrationBuilder.InsertData(
                table: "Contato_Tipo",
                columns: new[] { "CodigoContatoTipo", "NomeContato" },
                values: new object[] { 1, "Whatsapp" });

            migrationBuilder.InsertData(
                table: "Grupo",
                columns: new[] { "CodigoGrupo", "NomeGrupo", "Unico" },
                values: new object[] { 1, "Generico", true });

            migrationBuilder.InsertData(
                table: "NCM",
                columns: new[] { "Codigo", "Ano_Ato", "Data_Fim", "Data_Inicio", "Descricao", "Numero_Ato", "Tipo_Ato" },
                values: new object[] { "01", "2021", "31/12/9999", "01/04/2022", "Animais vivos", "000272", "Res Camex" });

            migrationBuilder.InsertData(
                table: "NCM_Estatistica",
                columns: new[] { "CodigoNCMEstatistica", "Ato", "Data_Ultima_Atualizacao_NCM" },
                values: new object[] { 1, "Resolução Camex nº 440/2022", "01/04/2023" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                column: "CodigoPessoa",
                value: 1);

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "CodigoProduto", "Ativo", "DataCadastro", "DescricaoCompletaProduto", "DescricaoResumidaProduto", "Eliminado", "NCMCodigo", "NomeProduto", "ProdutoClasseTerapeuticaCodigoClasseTerapeutica", "ProdutoFormulaCodigoFurmula", "RegistroMS" },
                values: new object[] { 1, true, new DateTime(2023, 8, 23, 2, 11, 58, 196, DateTimeKind.Local).AddTicks(709), "Descricao completa do produto", "Descricao Resumida do produto", false, null, "Nome do produto", null, null, null });

            migrationBuilder.InsertData(
                table: "Produto_ClasseTerapeutica",
                columns: new[] { "CodigoClasseTerapeutica", "NomeClasseTerapeutica" },
                values: new object[,]
                {
                    { 1, "Antimicrobiano" },
                    { 2, "Psicotropico" }
                });

            migrationBuilder.InsertData(
                table: "Produto_Embalagem",
                columns: new[] { "CodigoEmbalagem", "DescricaoEmbalagem", "QuantidadePorEmbalagem", "SiglaEmbalagem" },
                values: new object[] { 1, "Unidade", 1, "UN" });

            migrationBuilder.InsertData(
                table: "Substancia",
                columns: new[] { "CodigoSubstancia", "NomeSubstancia" },
                values: new object[,]
                {
                    { 1, "Dipirona Sodica" },
                    { 2, "Lozartana" },
                    { 3, "Lizina" },
                    { 4, "Midazolam" },
                    { 5, "Morfina" }
                });

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "CodigoContato", "CodigoContatoTipo", "CodigoPessoa", "DescricaoContato" },
                values: new object[] { 1, 1, 1, "17988414859" });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "CodigoEndereco", "CodigoBairro", "CodigoCidade", "CodigoPessoa", "Complemento", "Numero", "Rua" },
                values: new object[] { 1, 1, 1, 1, "Perdo da casa da maria", "1822", "Rua santa maria" });

            migrationBuilder.InsertData(
                table: "Pessoa_Fisica",
                columns: new[] { "CodigoPessoaFisica", "Ativo", "CPF", "CodigoPessoa", "DataCadastro", "DataNascimento", "Eliminado", "Nome", "NomeCompleto", "NomeSocial", "RG", "RGOrgao", "RGOrgaoUF", "Sexo", "UtilizaNomeSocial" },
                values: new object[] { 1, true, "69850578025", 1, new DateTime(2023, 8, 23, 2, 11, 58, 196, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Jeferson", "Jeferson Willian do prado martins", "", "402287897", "SSP", "SP", 0, false });

            migrationBuilder.InsertData(
                table: "Pessoa_Juridica",
                columns: new[] { "CodigoPessoaJuridica", "CNAE", "CNPJ", "CodigoPessoa", "DataCadastro", "IE", "NomeFantasia", "RazaoSocial" },
                values: new object[] { 1, "7518", "47473617000198", 1, new DateTime(2023, 8, 23, 2, 11, 58, 196, DateTimeKind.Local).AddTicks(646), "683462917135", "Nome Fantasia empresa LDTA", "Razão Social Empresa LTDA" });

            migrationBuilder.InsertData(
                table: "Produto_CodigoBarra",
                columns: new[] { "CodigoBarra", "CodigoProduto", "GTIN" },
                values: new object[] { 1, 1, "788848488484848" });

            migrationBuilder.InsertData(
                table: "ConfiguracaoEmpresa",
                columns: new[] { "CodigoEmpresa", "Ativo", "CodigoPessoaJuridica", "NomeFilial" },
                values: new object[] { 1, true, 1, "Empresa Teste" });

            migrationBuilder.InsertData(
                table: "Produto_Estoque",
                columns: new[] { "CodigoEstoque", "CodigoConfiguracaoEmpresa", "CodigoProduto", "Estoque" },
                values: new object[] { 1, 1, 1, 10 });

            migrationBuilder.InsertData(
                table: "Produto_Estatistica",
                columns: new[] { "CodigoEstatistica", "CodigoProdutoEstoque", "PrecoUltimaCompra", "PrecoUltimaVenda", "UltimaCompra", "UltimaVenda" },
                values: new object[] { 1, 1, 16.219999999999999, 32.219999999999999, new DateTime(2023, 8, 23, 2, 11, 58, 196, DateTimeKind.Local).AddTicks(777), new DateTime(2023, 8, 23, 2, 11, 58, 196, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.InsertData(
                table: "Produto_EstoqueControle",
                columns: new[] { "CodigoEstoqueControle", "CodigoProdutoEmbalagem", "CodigoProdutoEstoque", "CurvaABC", "DataCurvaAplicada", "EstoqueDemanda", "EstoqueDemandaMaxima", "EstoqueDemandaMinima", "EstoqueMaximo", "EstoqueMinimo" },
                values: new object[] { 1, 1, 1, "A", new DateTime(2023, 8, 23, 2, 11, 58, 196, DateTimeKind.Local).AddTicks(790), 58, 78, 38, 0, 0 });

            migrationBuilder.InsertData(
                table: "Produto_EstoquePrecificacao",
                columns: new[] { "CodigoEstoquePrecificacao", "CodigoProdutoEstoque", "Markup", "PrecoCompra", "PrecoCusto", "PrecoCustoMedio", "PrecoIncentivo" },
                values: new object[] { 1, 1, 120, 16.219999999999999, 19.23, 20.109999999999999, 0.0 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CodigoOrganizacao",
                table: "AspNetUsers",
                column: "CodigoOrganizacao");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracaoEmpresa_CodigoPessoaJuridica",
                table: "ConfiguracaoEmpresa",
                column: "CodigoPessoaJuridica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contato_CodigoContatoTipo",
                table: "Contato",
                column: "CodigoContatoTipo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contato_CodigoPessoa",
                table: "Contato",
                column: "CodigoPessoa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CodigoBairro",
                table: "Endereco",
                column: "CodigoBairro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CodigoCidade",
                table: "Endereco",
                column: "CodigoCidade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CodigoPessoa",
                table: "Endereco",
                column: "CodigoPessoa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Fisica_CodigoPessoa",
                table: "Pessoa_Fisica",
                column: "CodigoPessoa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Juridica_CodigoPessoa",
                table: "Pessoa_Juridica",
                column: "CodigoPessoa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_NCMCodigo",
                table: "Produto",
                column: "NCMCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ProdutoClasseTerapeuticaCodigoClasseTerapeutica",
                table: "Produto",
                column: "ProdutoClasseTerapeuticaCodigoClasseTerapeutica");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ProdutoFormulaCodigoFurmula",
                table: "Produto",
                column: "ProdutoFormulaCodigoFurmula");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CodigoBarra_CodigoProduto",
                table: "Produto_CodigoBarra",
                column: "CodigoProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Estatistica_CodigoProdutoEstoque",
                table: "Produto_Estatistica",
                column: "CodigoProdutoEstoque",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Estoque_CodigoConfiguracaoEmpresa",
                table: "Produto_Estoque",
                column: "CodigoConfiguracaoEmpresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Estoque_CodigoProduto",
                table: "Produto_Estoque",
                column: "CodigoProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_EstoqueControle_CodigoProdutoEmbalagem",
                table: "Produto_EstoqueControle",
                column: "CodigoProdutoEmbalagem",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_EstoqueControle_CodigoProdutoEstoque",
                table: "Produto_EstoqueControle",
                column: "CodigoProdutoEstoque",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_EstoqueLote_CodigoProdutoEstoque",
                table: "Produto_EstoqueLote",
                column: "CodigoProdutoEstoque",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_EstoquePrecificacao_CodigoProdutoEstoque",
                table: "Produto_EstoquePrecificacao",
                column: "CodigoProdutoEstoque",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Formula_substancia_CodigoSubstancia",
                table: "Produto_Formula_substancia",
                column: "CodigoSubstancia");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Grupo_ProdutosCodigoProduto",
                table: "Produto_Grupo",
                column: "ProdutosCodigoProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Imagem_ProdutoCodigoProduto",
                table: "Produto_Imagem",
                column: "ProdutoCodigoProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Substancia_NomeSubstancia",
                table: "Substancia",
                column: "NomeSubstancia",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "NCM_Estatistica");

            migrationBuilder.DropTable(
                name: "Pessoa_Fisica");

            migrationBuilder.DropTable(
                name: "Produto_CodigoBarra");

            migrationBuilder.DropTable(
                name: "Produto_Estatistica");

            migrationBuilder.DropTable(
                name: "Produto_EstoqueControle");

            migrationBuilder.DropTable(
                name: "Produto_EstoqueLote");

            migrationBuilder.DropTable(
                name: "Produto_EstoquePrecificacao");

            migrationBuilder.DropTable(
                name: "Produto_Formula_substancia");

            migrationBuilder.DropTable(
                name: "Produto_Grupo");

            migrationBuilder.DropTable(
                name: "Produto_Imagem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contato_Tipo");

            migrationBuilder.DropTable(
                name: "Bairro");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Produto_Embalagem");

            migrationBuilder.DropTable(
                name: "Produto_Estoque");

            migrationBuilder.DropTable(
                name: "Substancia");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Imagem");

            migrationBuilder.DropTable(
                name: "Organizacoes");

            migrationBuilder.DropTable(
                name: "ConfiguracaoEmpresa");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Pessoa_Juridica");

            migrationBuilder.DropTable(
                name: "NCM");

            migrationBuilder.DropTable(
                name: "Produto_ClasseTerapeutica");

            migrationBuilder.DropTable(
                name: "Produto_Formula");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
