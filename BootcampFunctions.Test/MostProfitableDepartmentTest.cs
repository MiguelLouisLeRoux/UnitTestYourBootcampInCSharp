using System;
using System.Collections.Generic;
using Xunit;
namespace BootcampFunctions.Test
{
    public class MostProfitableDepartmentTest
    {
        [Fact]
        public void ShouldReturnOutdoor()
        {
            var theDepartment = new MostProfitableDepartment();

            Assert.Equal("outdoor", theDepartment.mostProfitableDepartment(theDepartment.GetMostProfitableData()));
        }
    }
}