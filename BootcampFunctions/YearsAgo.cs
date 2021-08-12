using System;

namespace BootcampFunctions
{
    public class YearsAgo
    {
         public int yearsAgo(int theYear)
        {
            var year = DateTime.Now;
            var thisYear = year.Year;
            var ago = thisYear - theYear;
           
            return ago;
        }
    }
}
