using System.Collections.Generic;

namespace BootcampFunctions
{
    public class CountAllFromTown
    {
        public int countAllFromTown(string regNumbers, string town)
        {
            var regList = regNumbers.Split(",");
            var townList = new List<string>();
            foreach(var regNumber in regList)
            {
                if (regNumber.Contains(town))
                {
                    townList.Add(regNumber);
                }
            }
            return townList.Count;
        }
    }
}