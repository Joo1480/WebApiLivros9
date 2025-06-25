using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Application.Interfaces;
using WebApiLivros9.Application.Mappings;
using WebApiLivros9.Domain.Interfaces;
using WebApiLivros9.Infra.Data.Context;
using WebApiLivros9.Infra.Data.Repositories;
using AutoMapper;
using WebApiLivros9.Application.Services;

namespace WebApiLivros9.Infra.Ioc
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            services.AddScoped<IClienteRepository, ClienteRepository>();

            services.AddScoped<IClienteService, ClienteService>();

            return services;
        }
    }
}
