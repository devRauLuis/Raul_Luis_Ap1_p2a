using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazored.Toast;
using Raul_Luis_Ap2_p2a.DAL;
using Raul_Luis_Ap2_p2a.BLL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredToast();

builder.Services.AddDbContext<ProductsContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
    opt.EnableSensitiveDataLogging();

}, ServiceLifetime.Scoped);

builder.Services.AddTransient<ProductosBLL>();
builder.Services.AddTransient<ProductosEmpacadosBLL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
