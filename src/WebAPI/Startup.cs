using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI.Helpers;
using InterfacesContrats.UserInterfaces;
using WebApi.Helpers;
using Entities.Repo;
using WebAPI.AutoMapper;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureServiceLogging();

            services.AddCors();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserRepo, UserRepo>();

            services.ConfigureContextSql(Configuration);

            services.ConfigureGestionRepos();

            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile<CarburantProfile>();
                config.AddProfile<MarqueProfile>();
                config.AddProfile<ReleveProfile>();
                config.AddProfile<StationServiceProfile>();
                config.AddProfile<UserProfile>();
            });

            services.AddAutoMapper(typeof(Startup));

            mapperConfig.AssertConfigurationIsValid();

            services.AddSwaggerGen();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project Valarep CDA June 2021");
                c.RoutePrefix = "api/home";
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}