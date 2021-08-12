using Xunit;
using System.Text.Json;
namespace BootcampFunctions.Test
{

    public class FindItemsOverTest
    {
        [Fact]
        public void ShouldReturn1ItemOver40()
        {
            //The method
            var ItemsOverTest = new FindItemsOver();
            var itemsOverTest = JsonSerializer.Serialize(ItemsOverTest.FindItemsOverThreshold(ItemsOverTest.GetItemsOverList(), 40));

            //The expected list test
            var expectedList = new ItemsOver();
            var theExpectedList = JsonSerializer.Serialize(expectedList.FindItemsOver40AssertTestList());

            Assert.Equal(theExpectedList, itemsOverTest);
        }

        [Fact]
        public void ShouldReturn4ItemsOver30()
        {
            //The method
            var ItemsOverTest = new FindItemsOver();
            var itemsOverTest = JsonSerializer.Serialize(ItemsOverTest.FindItemsOverThreshold(ItemsOverTest.GetItemsOverList(), 30));

            //The expected list test
            var expectedList = new ItemsOver();
            var theExpectedList = JsonSerializer.Serialize(expectedList.FindItemsOver30AssertTestList());

            Assert.Equal(theExpectedList, itemsOverTest);
        }
    }
}