using System;
using System.Collections.Generic;
using Xunit;
using System.Text.Json;

namespace BootcampFunctions.Test
{
    public class FindItemsOver20Test
    {
        [Fact]
        public void AllFindItemsOver20Test()
        {
            //The method
            var FindItemsOver20Test = new FindItemsOver20();
            var findItemsOver20Test = JsonSerializer.Serialize(FindItemsOver20Test.ItemsOver20(FindItemsOver20Test.GetItemsOverList()));


            //The expected list test
            var expectedList = new ItemsOver();
            var theExpectedList = JsonSerializer.Serialize(expectedList.FindItemsOver20AssertTestList());

            Assert.Equal(theExpectedList, findItemsOver20Test);
        }
    }
}