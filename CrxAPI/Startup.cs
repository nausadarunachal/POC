using System;
using System.IO;
using AutoMapper;
using WebAPI.DependencyInjection;
using WebAPI.FluentValidator;
using WebAPI.Swagger;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //Nlog config
            LogManager.LoadConfiguration(System.String.Concat(Directory.GetCurrentDirectory(), "/Logging/nlog.config"));
            Configuration = configuration;

        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwagger();
            services.AddControllers();
            IoC.Resolver(services);
            services.AddMvc(opt =>
            {
                opt.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());



            //// Start Registering and Initializing AutoMapper
            services.AddAutoMapper(new Type[]
            {
                typeof(BAL.AutoMapper.MappingProfile)
            }
                                  );

            //services.AddSingleton<INLogging, NLogging>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();
            
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            //Swashbuckle.AspNetCore.Filters to v 5.0.0-rc2
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseCustomSwagger();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
