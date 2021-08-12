using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class TransportFeeTest
    {
        [Fact]
        public void ShouldReturnR10ForAfternoon()
        {
            var transport = new TransportFee();

            Assert.Equal("R10", transport.transportFee("afternoon"));
        }

        [Fact]
        public void ShouldReturnR20ForMorning()
        {
            var transport = new TransportFee();

            Assert.Equal("R20", transport.transportFee("morning"));
        }
    }
}