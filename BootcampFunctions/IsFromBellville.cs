namespace BootcampFunctions
{
    public class IsFromBellville
    {
        public bool isFromBellville(string regChar)
        {
            if (regChar.StartsWith("CY"))
            {
                return true;
            }
            return false;
        }
    }
}