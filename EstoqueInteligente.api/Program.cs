using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interfaces;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Infra.Repositories;
using EstoqueInteligente.Service.Intefaces;
using EstoqueInteligente.Service.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
#region Context
builder.Services.AddDbContext<EstoqueInteligenteContext>();
#endregion

builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<INCMRepository, NCMRepository>();
builder.Services.AddScoped<IFormulaRepository, FormulaRepository>();
builder.Services.AddScoped<ISubstanciaRepository, SubstanciaRepository>();
builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();
builder.Services.AddScoped<IGrupoService, GrupoService>();

builder.Services.AddScoped<INCMService, NCMService>();
builder.Services.AddScoped<IFormulaService, FormulaService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
