using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Examen2.Domain.InvestigadorContext.Repositories;
using Examen2.Infrastructure.InvestigadorContext;
using Examen2.Infrastructure.InvestigadorContext.Repositories;

namespace Examen2.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<InvestigadorDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IInvestigadorRepository, InvestigadorRepository>();
            return services;
        }

    }
}
