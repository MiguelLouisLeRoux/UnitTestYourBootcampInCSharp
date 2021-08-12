namespace BootcampFunctions
{
    public class CountRegNumber
    {
        public int countRegNumber(string regNumbers)
        {
            var regList = regNumbers.Split(",");
            return regList.Length;
        }
        
    }
}