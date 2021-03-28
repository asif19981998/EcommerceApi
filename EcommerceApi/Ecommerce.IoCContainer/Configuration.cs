using Ecommerce.BLL.Abstractions.EntityManager;
using Ecommerce.BLL.Abstractions.EntityManagerContracts;
using Ecommerce.BLL.EntityManager;
using Ecommerce.DataBaseContext;
using Ecommerce.Repositories;
using Ecommerce.Repositories.Abstractions.EntityContracts;
using Ecommerce.Repositories.EntityRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.IoCContainer
{
    public static class IoConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
           services.AddTransient<IProductManager,ProductManager>();
           services.AddTransient < IShopManager,ShopManger > ();
           services.AddTransient<IProuductRespository, ProductRepository>();
           services.AddTransient<IShopRepository, ShopRepository>();
           services.AddTransient<DbContext, EcommerceDbContext>();
           services.AddTransient<EcommerceDbContext>();

        }
    }
}
