using Blazored.Modal;
using Blazored.Toast;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLAoW.UI.Web.Configurations
{
    public static class ComponentsConfigurator
    {
        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration"></param>
        public static void ConfigureBlazored(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBlazoredToast();
            services.AddBlazoredModal();
        }
    }
}
