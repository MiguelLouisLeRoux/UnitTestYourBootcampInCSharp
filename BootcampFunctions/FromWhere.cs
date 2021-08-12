namespace BootcampFunctions
{
    public class FromWhere
    {
        public string fromWhere(string regChar)
        {
            if(regChar.StartsWith("CA")){
                return "Cape Town";
            } else if (regChar.StartsWith("CY"))
            {
                return "Bellville";
            } else if (regChar.StartsWith("CJ"))
            {
                return "Paarl";
            }
            return "Some other place!";
        }
    }
}