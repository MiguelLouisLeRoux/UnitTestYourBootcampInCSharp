using System.Collections.Generic;

namespace BootcampFunctions
{
    public class FindItemsOver
    {
         //Method Gets the Deserialized list to be parsed through the method.
        public List<ItemsOverClass> GetItemsOverList()
        {
            var theItems = new ItemsOver();

            return theItems.FindItemsOver();
        }

        //Method filteres all items over given threshold
        public List<ItemsOverClass> FindItemsOverThreshold(List<ItemsOverClass> GetItemsOverList, int threshold)
        {
            var itemsOverList = new List<ItemsOverClass>();

            for(int i = 0; i < GetItemsOverList.Count; i++)
            {
                var itt = GetItemsOverList[i];
                if(itt.qty > threshold)
                {
                    itemsOverList.Add(itt);
                }
            }
            return itemsOverList;
        }
    }
}