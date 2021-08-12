using System;
using Xunit;
namespace BootcampFunctions.Test
{
    public class IsWeekDayTest
    {
        [Fact]
        public void ShouldReturnTrueForWeekday()
        {
            var day = new IsWeekDay();

            Assert.True(day.isWeekDay("Friday"));
        }

        [Fact]
        public void ShouldReturnFalseAsNotWeekday()
        {
            var day = new IsWeekDay();

            Assert.False(day.isWeekDay("Saturday"));
        }
    }
}