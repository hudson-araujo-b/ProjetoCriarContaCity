using ProjetoCriarConta.Interfaces;
using ProjetoCriarConta.Models;
using ProjetoCriarConta.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
