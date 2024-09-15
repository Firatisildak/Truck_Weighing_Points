using GeotekProject.Application.Interfaces;
using GeotekProject.Persistence.Context;
using GeotekProject.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GeotekProjectDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
            services.AddScoped<IKamyonRepository, KamyonRepository>();
            services.AddScoped<IKantarRepository, KantarRepository>();
            services.AddScoped<IBosaltmaRepository, BosaltmaRepository>();

        }
    }
}
