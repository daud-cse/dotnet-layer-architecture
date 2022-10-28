using DAL.Contexts;
using DAL.interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class  DepandancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DotNetDbContext");
            services.AddDbContext<DotNetDbContext>(options =>
               options.UseSqlServer(defaultConnectionString));


            services.AddTransient<IIncomeAndCostRepository, IncomeAndCostRepository>();
            
            services.AddScoped<DotNetDbContext, DotNetDbContext>();
            var serviceProvider = services.BuildServiceProvider();
            try
            {
                var dbContext = serviceProvider.GetRequiredService<DotNetDbContext>();
                dbContext.Database.Migrate();
            }
            catch
            {
            }

            return services;
        }
    }
}
