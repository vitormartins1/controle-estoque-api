using Estoque.BUSINESS.Business;
using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.Context;
using Estoque.DATA.Interfaces;
using Estoque.DATA.Repository;
using EstoqueAPI.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EstoqueDbContext>(
    options => options.UseLazyLoadingProxies().UseSqlServer(
        builder.Configuration.GetConnectionString("EstoqueDBConnection"),
        b => b.MigrationsAssembly("EstoqueAPI")));
builder.Services.AddEstoqueService();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Estoque API",
        Version = "v1",
        Description = "API de gerenciamento de estoque que compõe um sistema de contas a pagar e controle de produtos.",
        Contact = new OpenApiContact
        {
            Name = "Vitor Martins",
            Url = new Uri("https://github.com/vitormartins1")
        }
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
    options.DocumentFilter<PathLowercaseDocumentFilter>();
    options.EnableAnnotations();
    var security = new Dictionary<string, IEnumerable<string>>
    {
        {
            "Bearer", 
            new string[] { }
        },
    };

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer'[space] and then your token in the text input below. \r\n\r\nExample: \"Bearer 12345abcdef\"",
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger(options => 
    {
        //options.RouteTemplate = "docs/api/{documentname}/swagger.json";
    });
    app.UseSwaggerUI(options => 
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Estoque API v1");
        //options.SwaggerEndpoint("/docs/api/v1/swagger.json", "Estoque API v1");
        //options.RoutePrefix = "docs/api";
        //options.InjectStylesheet("/swagger-ui/theme-material.css");
    });
}

app.UseHttpsRedirection();
//app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();

app.Run();

