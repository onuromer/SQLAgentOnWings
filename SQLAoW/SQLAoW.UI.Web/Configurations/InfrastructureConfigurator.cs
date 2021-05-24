using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SQLAoW.Infrastructure;
using SQLAoW.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLAoW.UI.Web.Configurations
{
    public static partial class InfrastructureConfigurator
    {
        public static void InjectInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IStorage, Storage>();
            services.AddTransient<IQueryService, RepoDBQueryService>();
            services.AddTransient<SQLAgentService>();
        }
    }
}
