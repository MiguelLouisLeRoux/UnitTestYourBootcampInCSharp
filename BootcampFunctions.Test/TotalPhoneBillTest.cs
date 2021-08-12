using System;
using Xunit;
namespace BootcampFunctions.Test
{ 
    public class TotalPhoneBillTest
    {
        [Fact]
        public void ShouldReturnR955ForTotal()
        {
            var bill = new TotalPhoneBill();

            Assert.Equal("R 9.55", bill.totalPhoneBill("call, sms, call, call, sms"));
        }

        [Fact]
        public void ShouldReturnR1505ForTotal()
        {
            var bill = new TotalPhoneBill();

            Assert.Equal("R 15.05", bill.totalPhoneBill("call, sms, call, call, sms, call, call"));
        }
    }
 
}