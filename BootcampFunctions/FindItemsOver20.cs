
using System.Collections.Generic;
namespace BootcampFunctions
{
    public class FindItemsOver20
    {

        //Method Gets the Deserialized list to be parsed through the method.
        public List<ItemsOverClass> GetItemsOverList()
        {
            var theItems = new ItemsOver();

            return theItems.FindItemsOver();
        }

        //Method filteres all items over 20
        public List<ItemsOverClass> ItemsOver20(List<ItemsOverClass> GetItemsOverList)
        {
            var itemsOver20List = new List<ItemsOverClass>();

            for(int i = 0; i < GetItemsOverList.Count; i++)
            {
                var itt = GetItemsOverList[i];
                if(itt.qty > 20)
                {
                    itemsOver20List.Add(itt);
                }
            }
            return itemsOver20List;
        }
    }
}