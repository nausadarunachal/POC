using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace WebAPI.Swagger
{
    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Employee API",
                    Version = "v1",
                    Description = "An API to perform operations",
                    TermsOfService = new Uri("https://galaxe.com/terms-and-conditions/"),
                    Contact = new OpenApiContact
                    {
                        Name = "Nausad Ansari",
                        Email = "nansari@galaxe.com",
                        Url = new Uri("https://twitter.com/nausadarunachal"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "GalaxE Solutions",
                        Url = new Uri("https://galaxe.com/gxfource/"),
                    }
                });

                c.DescribeAllEnumsAsStrings();
                c.DescribeStringEnumsInCamelCase();
            });
        }
        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
               // c.SwaggerEndpoint("/swagger/v2/swagger.json", "My API V2");
            });
        }
    }
}
