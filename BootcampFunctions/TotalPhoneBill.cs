namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
         public string totalPhoneBill(string action)
        {
            double value = 0.0;
            var list = action.Split(",");
            for(var i =0; i < list.Length; i++){
                var trim = list[i].Trim();
                if(trim == "call")
                {
                    value += 2.75;
                } else if (trim == "sms")
                {
                    value += 0.65;
                }
            }
            return $"R {value}";
        }
    }
}