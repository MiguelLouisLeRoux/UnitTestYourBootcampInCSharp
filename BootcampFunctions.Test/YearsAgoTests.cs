using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class YearsAgoTests
    {
        [Fact]
        public void ShouldReturn7YearAgoFor2014()
        {
            var ago = new YearsAgo();

            Assert.Equal(7, ago.yearsAgo(2014));
        }

        [Fact]
        public void ShouldReturn10YearsAgoFor2011()
        {
            var ago = new YearsAgo();

            Assert.Equal(10, ago.yearsAgo(2011));
        }
    }
    
}