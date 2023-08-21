using EstoqueInteligente.Domain.Entities.Identity;
using EstoqueInteligente.Infra.Context;
using EstoqueInteligente.Infra.Interface.Repository;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Infra.Repositories;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();
//builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();

#region IdentityCore
//builder.Services.AddIdentityCore<User>(options =>
//{
//    options.Password.RequireDigit = false;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequireLowercase = false;
//    options.Password.RequireUppercase = false;
//    options.Password.RequiredLength = 4;
//    options.User.RequireUniqueEmail = true;
//    options.SignIn.RequireConfirmedEmail = true;



//    options.Lockout.MaxFailedAccessAttempts = 3;
//    options.Lockout.AllowedForNewUsers = true;
//}).AddRoles<Role>()
//            .AddEntityFrameworkStores<Context>()
//            .AddRoleValidator<RoleValidator<Role>>()
//            .AddRoleManager<RoleManager<Role>>()
//            .AddSignInManager<SignInManager<User>>()
//            .AddDefaultTokenProviders();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
