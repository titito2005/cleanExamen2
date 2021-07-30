using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Examen2.Domain.Core.CoreEntities;
using Xunit;

namespace Lab2.UnitTests.Domain.Core
{
    public class GrupoInvestigacionTest
    {
        [Fact]
        public void TryCreateGrupoInvestigacion()
        {
            var newCanton = new GrupoInvestigacion();
            /*
            Assert.Equal("Agua Caliente", newCanton.Name); //Get and test Set
            Assert.Equal("Cartago", newCanton.Province_Name); //Get and test Set
            */
        }
    }
}