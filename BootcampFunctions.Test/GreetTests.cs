using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public partial class GreetTest
    {
        [Fact]
        public void ShouldGreetPete()
        {
            var bootCamp = new Greet();

            Assert.Equal("Hello, Pete", bootCamp.greet("Pete"));
        }

        [Fact]
        public void ShouldGreetJack()
        {
            var bootCamp = new Greet();

            Assert.Equal("Hello, Jack", bootCamp.greet("Jack"));
        }
    }
}