using Estoque.BUSINESS.Business;
using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.Interfaces;
using Estoque.DATA.Repository;

namespace EstoqueAPI.Configuration
{
    /// <summary>
    /// Adiciona as injeções de dependência da aplicação
    /// Métodos que adicionam as injeções de dependências do Service, Business e do Repository
    /// Metodo geral 
    /// IoC Inversion of Control - Principio da injeção de dependências.
    /// Você chama uma interface nas sua classes para poder ter acesso a alguns metodos
    /// e quando essa interface é chamada em tempo de execução ela passa o controle para a 
    /// classe que implementa ela concretamente.
    /// Em tempo de execução ocorre a inversão de controle que é o IoC. Passa o controle para
    /// a classe concreta poder executar o método. 
    /// </summary>
    public static class IoCConfig
    {
        public static IServiceCollection AddEstoqueService(this IServiceCollection services)
        {
            services.AddRepositoryService();
            services.AddBusinessService();
            //services.AddHelpersService();

            return services;
        }

        private static IServiceCollection AddRepositoryService(this IServiceCollection service)
        {
            service.AddScoped<IProdutoRepository, ProdutoRepository>();
            service.AddScoped<IVendaRepository, VendaRepository>();
            service.AddScoped<IItemRepository, ItemRepository>();
            service.AddScoped<IEstoqueRepository, EstoqueRepository>();

            return service;
        }

        private static IServiceCollection AddBusinessService(this IServiceCollection service)
        {
            service.AddScoped<IProdutoBusiness, ProdutoBusiness>();
            service.AddScoped<IVendaBusiness, VendaBusiness>();
            service.AddScoped<IItemBusiness, ItemBusiness>();
            service.AddScoped<IEstoqueBusiness, EstoqueBusiness>();

            return service;
        }

        private static IServiceCollection AddHelpersService(this IServiceCollection service)
        {
            return service;
        }
    }
}
