using System.Collections.Generic;
using System.Text.Json;

namespace BootcampFunctions
{

    //Most Profitable Department Data Deserialization
    public class MostProfitableDataClass
    {
        
        public string department { get; set; }
        public int sales { get; set; }
        public string day { get; set; }

    }

    public class MostProfitable
    {
        public List<MostProfitableDataClass> MostProfitableData()
        {
            var jsClassList = new List<MostProfitableDataClass>();

            string input = @"{""department"":""hardware"",""sales"":4500,""day"":""Monday""};{""department"":""outdoor"",""sales"":1500,""day"":""Monday""};{""department"":""carpentry"",""sales"":5500,""day"":""Monday""};{""department"":""hardware"",""sales"":7500,""day"":""Tuesday""};{""department"":""outdoor"",""sales"":2505,""day"":""Tuesday""};{""department"":""carpentry"",""sales"":1540,""day"":""Tuesday""};{""department"":""hardware"",""sales"":1500,""day"":""Wednesday""};{""department"":""outdoor"",""sales"":8507,""day"":""Wednesday""};{""department"":""carpentry"",""sales"":8009,""day"":""Wednesday""};{""department"":""hardware"",""sales"":12000,""day"":""Thursday""};{""department"":""outdoor"",""sales"":18007,""day"":""Thursday""};{""department"":""carpentry"",""sales"":6109,""day"":""Thursday""};{""department"":""hardware"",""sales"":7005,""day"":""Friday""};{""department"":""outdoor"",""sales"":12006,""day"":""Friday""};{""department"":""carpentry"",""sales"":16109,""day"":""Friday""}";

            var JSONlist = input.Split(";");

            foreach (var obj in JSONlist)
            {
                MostProfitableDataClass theClass = JsonSerializer.Deserialize<MostProfitableDataClass>(obj);
                jsClassList.Add(theClass);
            }
            return jsClassList;
        }
    }

    //Items Over Data Deserialization
    public class ItemsOverClass
    {
        public string name { get; set;}
        public int qty { get; set;}
    }

    public class ItemsOver
    {
        public List<ItemsOverClass> FindItemsOver()
        {
            var jsClassList = new List<ItemsOverClass>();

            var itemsData = @"{""name"":""apples"",""qty"":10};{""name"":""oranges"",""qty"":37};{""name"":""bananas"",""qty"":27};{""name"":""apples"",""qty"":3};{""name"":""cakes"",""qty"":33};{""name"":""chocolates"",""qty"":43};{""name"":""peaches"",""qty"":33}";

            var JSONlist = itemsData.Split(";");

            foreach (var obj in JSONlist)
            {
                ItemsOverClass theClass = JsonSerializer.Deserialize<ItemsOverClass>(obj);
                jsClassList.Add(theClass);
            }
            return jsClassList;
        }

        //Returns List used to test FindItemsOver20 Method against
        public List<ItemsOverClass> FindItemsOver20AssertTestList()
        {
            var jsClassList = new List<ItemsOverClass>();

            var itemsData = @"{""name"":""oranges"",""qty"":37};{""name"":""bananas"",""qty"":27};{""name"":""cakes"",""qty"":33};{""name"":""chocolates"",""qty"":43};{""name"":""peaches"",""qty"":33}";

            var JSONlist = itemsData.Split(";");

            foreach (var obj in JSONlist)
            {
                ItemsOverClass theClass = JsonSerializer.Deserialize<ItemsOverClass>(obj);
                jsClassList.Add(theClass);
            }
            return jsClassList;
        }

        //Returns List used to test FindItemsOver Method against
        public List<ItemsOverClass> FindItemsOver30AssertTestList()
        {
            var jsClassList = new List<ItemsOverClass>();

            var itemsData = @"{""name"":""oranges"",""qty"":37};{""name"":""cakes"",""qty"":33};{""name"":""chocolates"",""qty"":43};{""name"":""peaches"",""qty"":33}";

            var JSONlist = itemsData.Split(";");

            foreach (var obj in JSONlist)
            {
                ItemsOverClass theClass = JsonSerializer.Deserialize<ItemsOverClass>(obj);
                jsClassList.Add(theClass);
            }
            return jsClassList;
        }

        //Returns List used to test FindItemsOver Method against
        public List<ItemsOverClass> FindItemsOver40AssertTestList()
        {
            var jsClassList = new List<ItemsOverClass>();

            var itemsData = @"{""name"":""chocolates"",""qty"":43}";

                ItemsOverClass theClass = JsonSerializer.Deserialize<ItemsOverClass>(itemsData);
                jsClassList.Add(theClass);
            return jsClassList;
        }
    }

}