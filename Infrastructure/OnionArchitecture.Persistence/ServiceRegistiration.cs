using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration )
        {

            //burada microsoft.extensions.configuration.json dan da yararlanılabilir eğer ki daha fazla konfigürasyon gerekecekse
            services.AddDbContext<OnionArchitectureDbContext>(options=>options.UseSqlServer(configuration.GetConnectionString("MsSql")));
        }
    }
}
