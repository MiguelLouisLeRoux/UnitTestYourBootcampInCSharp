using System;
using Xunit;
namespace BootcampFunctions.Test
{

    public class IsFromBellvilleTest
    {
        [Fact]
        public void ShouldReturnTrueForBellville()
        {
            var bellville = new IsFromBellville();

            Assert.True(bellville.isFromBellville("CY 215 18"));

        }

        [Fact]
        public void ShouldReturnFalseAsNotFromBellville()
        {
            var bellville = new IsFromBellville();

            Assert.False(bellville.isFromBellville("CJ 215 18"));

        }
    }

}