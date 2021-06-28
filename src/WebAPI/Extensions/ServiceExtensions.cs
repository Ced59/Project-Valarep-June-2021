using Entities.Repo;
using InterfacesContrats.Logger;
using InterfacesContrats.RepositoryInterfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using ServiceLogging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Extentions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceLogging(this IServiceCollection services) => services.AddScoped<ILoggable, Logger>();

        //TODO : Décommenter quand
        //public static void ConfigureGestionRepos(this IServiceCollection services) => services.AddScoped<IGestionRepos, GestionRepos>();

        //TODO Ajouter le service pour configurer l'accès à la bdd quand on connaitra le moteur à utiliser
    }
}