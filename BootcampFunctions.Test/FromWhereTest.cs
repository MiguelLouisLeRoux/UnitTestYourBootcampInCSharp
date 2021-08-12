using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class FromWhereTest
    {
        [Fact]
        public void ShouldReturnPaarl()
        {
            var place = new FromWhere();

            Assert.Equal("Paarl", place.fromWhere("CJ"));
        }

        [Fact]
        public void ShouldReturnCapeTown()
        {
            var place = new FromWhere();

            Assert.Equal("Cape Town", place.fromWhere("CA"));
        }
    }

}