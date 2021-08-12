using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class CountAllPaarlTest
    {
        [Fact]
        public void ShouldReturnFiveRegNumbersForPaarl()
        {
            var paarlCount = new CountAllPaarl();

            Assert.Equal(5, paarlCount.countAllPaarl("CJ 345 123, CJ 2345, CL 123-546, CK 345, CJ 123, CJ 5552, CJ 9334"));

        }

        [Fact]
        public void ShouldReturnThreeRegNumbersForPaarl()
        {
            var paarlCount = new CountAllPaarl();

            Assert.Equal(3, paarlCount.countAllPaarl("CL 123-546, CK 345, CJ 123, CJ 5552, CJ 9334"));

        }
    }
}