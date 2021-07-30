using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Examen2.Domain.InvestigadorContext.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Examen2;
using Examen2.Domain.Core.CoreEntities;
using Examen2.Server;

namespace Lab2.IntegrationTests.InvestigadorContext.Infraestructure.Repositories
{
    public class InvestigadorContextIntegrationTests : IClassFixture<InvestigadorContextFactory<Startup>>
    {
        private readonly InvestigadorContextFactory<Startup> _factory;

        InvestigadorContextIntegrationTests(InvestigadorContextFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task getProductsByInput()
        {
            var repository = _factory.Server.Services.GetRequiredService<IInvestigadorRepository>();
        }
    }
}
