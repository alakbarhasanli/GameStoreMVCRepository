using Ecommers.BL.Profiles;
using Ecommers.BL.Services.Abstractions;
using Ecommers.BL.Services.Implementetions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Ecommers.BL.ExtensionsForBl;

public static class ServiceExtensionsBL
{

    public static void AddServiceRepostoriesforBL(this IServiceCollection services)
    {
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IOrderItemService, OrderItemService>();
        services.AddScoped<IProductService, ProductService>();

        services.AddAutoMapper(Assembly.GetAssembly(typeof(OrderProfile)));
        services.AddAutoMapper(Assembly.GetAssembly(typeof(OrderItemProfile)));
        services.AddAutoMapper(Assembly.GetAssembly(typeof(ProductProfile)));

    }


}
