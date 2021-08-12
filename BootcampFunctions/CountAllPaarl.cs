using System.Collections.Generic;

namespace BootcampFunctions
{
    public class CountAllPaarl
    {
        public int countAllPaarl(string regNumbers)
        {
            var regList = regNumbers.Split(",");
            var paarlList = new List<string>();

            foreach(var regNumber in regList)
            {
                if(regNumber.Contains("CJ"))
                {
                    paarlList.Add(regNumber);
                }
            }
            return paarlList.Count;
        }
    }
}