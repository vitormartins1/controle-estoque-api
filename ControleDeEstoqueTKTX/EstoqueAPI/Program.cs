using Estoque.BUSINESS.Business;
using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.Context;
using Estoque.DATA.Interfaces;
using Estoque.DATA.Repository;
using EstoqueAPI.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EstoqueDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("EstoqueDBConnection"),
        b => b.MigrationsAssembly("EstoqueAPI")));
builder.Services.AddEstoqueService();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Estoque API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Estoque API v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();