using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using System.Configuration;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

var strConn = configuration.GetConnectionString("SalesWebMvcContext");

builder.Services.AddDbContext<SalesWebMvcContext>(options =>
    options.UseMySql(strConn, ServerVersion.AutoDetect(strConn)));

builder.Services.AddScoped<SeedingService>();

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Adicionando o SeedingService
using (var scope = app.Services.CreateScope())
{
    var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
    await seedingService.Seed(); // Mudando para um método assíncrono
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
