using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class CountAllFromTownTest
    {
        [Fact]
        public void ShouldReturnNumberOfRegNumbersForCapeTown()
        {
            var count = new CountAllFromTown();

            Assert.Equal(2, count.countAllFromTown("CA 213 45, CJ 896 451, CY 456 021, CA 321 456", "CA"));

        }

        [Fact]
        public void ShouldReturnNumberOfRegNumbersForBellville()
        {
            var count = new CountAllFromTown();

            Assert.Equal(1, count.countAllFromTown("CA 213 45, CJ 896 451, CY 456 021, CA 321 456", "CY"));

        }
    }
}