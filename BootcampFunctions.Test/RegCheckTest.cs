using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class RegCheckTest
    {
        [Fact]
        public void ShouldReturnTrueForCapeTownMatch()
        {
            var reg = new RegCheck();

            Assert.True(reg.regCheck("CA 202 42", "CA"));

        }

        [Fact]
        public void ShouldReturnFalseAsNoMatchForPaarl()
        {
            var reg = new RegCheck();

            Assert.False(reg.regCheck("CY 202 42", "CJ"));

        }
    }
}