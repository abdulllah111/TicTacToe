using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicTacToe.App.Interfaces;

namespace TicTacToe.Persistense.Npsql
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration){
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<AppDbContext>(options =>{
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IAppDbContext>(provider =>
                provider.GetService<AppDbContext>()!);
            return services;
        }
    }
}