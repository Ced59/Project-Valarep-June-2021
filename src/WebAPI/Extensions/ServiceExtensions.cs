using Entities.Repo;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using ServiceLogging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceLogging(this IServiceCollection services) => services.AddScoped<ILoggable, Logger>();


        public static void ConfigureContextSql(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepoContext>(opts => opts.UseSqlServer(config.GetConnectionString("sqlConn"), opts => opts.MigrationsAssembly("WebAPI")));
        }

        //TODO : Décommenter quand
        public static void ConfigureGestionRepos(this IServiceCollection services) => services.AddScoped<IGestionRepos, GestionRepos>();


    }
}