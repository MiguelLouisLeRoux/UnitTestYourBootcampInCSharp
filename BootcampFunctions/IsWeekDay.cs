namespace BootcampFunctions
{
    public class IsWeekDay
    {
        
        public bool isWeekDay(string theDay)
        {
            if (theDay.StartsWith("Mon"))
            {
                return true;
            } else if (theDay.StartsWith("Tue"))
            {
                return true;
            } else if (theDay.StartsWith("Wedn"))
            {
                return true;
            } else if (theDay.StartsWith("Thur"))
            {
                return true;
            } else if (theDay.StartsWith("Fri"))
            {
                return true;
            }
            return false;
        }
    }
}