using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Application.InvestigadorContext;
using Examen2.Application.InvestigadorContext.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Examen2.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IInvestigadorService, InvestigadorService>();
            return services;
        }
    }
}