using System.Collections.Generic;
using System.Linq;
using Examen2.Application.InvestigadorContext.Implementations;
using Examen2.Domain.InvestigadorContext.E
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit;
using Examen2.Infrastructure.InvestigadorContext.Repositories;
using Examen2.Domain.InvestigadorContext.Repositories;

namespace Lab2.UnitTests.Application.Investigador
{
    public class InvestigadorServiceTest
    {

        [Fact]
        public async Task GetTeamsAsyncShouldReturnTeamDTOs()
        {
            // arrange
            var investigadores = GetListInvestigadorAsync();
            var mockTeamRepository = new Mock<IInvestigadorRepository>();
            mockTeamRepository.Setup(repo =>
            repo.GetListInvestigadorAsync()).ReturnsAsync(investigadores);
            var investigadorService = new InvestigadorService(mockTeamRepository.Object);
            // act
            var results = await investigadorService.GetListInvestigadorAsync();
            // assert
            results.Should().BeEquivalentTo(investigadores);
        }
    }
}
