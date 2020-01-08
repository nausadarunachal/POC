using BAL;
using CrxAPI.Logging;
using Interface.BAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrxAPI.DependencyInjection
{
    public static class IoC 
    {
        public static IServiceCollection Resolver(IServiceCollection services)
        { 
            services.AddSingleton<INLogging, NLogging>();
            services.AddSingleton<IHomeBAL, HomeBAL>();
            return services;
        }
    }
}
