using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class CountRegNumbersTest
    {
        [Fact]
        public void ShouldReturnFourRegNumbers()
        {
            var regCount = new CountRegNumber();

            Assert.Equal(4, regCount.countRegNumber("CA 213 45, CJ 896 451, CY 456 021, CA 321 456"));

        }

        [Fact]
        public void ShouldReturnTwoRegNumbers()
        {
            var regCount = new CountRegNumber();

            Assert.Equal(2, regCount.countRegNumber("CA 213 45, CJ 896 451"));

        }
    }
}