using System.Collections.Generic;

namespace BootcampFunctions
{
    public class MostProfitableDepartment
    {
        //Get Most Profitable List data
        public List<MostProfitableDataClass> GetMostProfitableData()
        {
            var theList = new MostProfitable();
            return theList.MostProfitableData();
        }

        //Method for Most Profitable Department
        public string mostProfitableDepartment(List<MostProfitableDataClass> GetMostProfitableData)
        {
            Dictionary<string, int> departmentSales = new Dictionary<string, int>();
            string theDepartment = "department";
            int sales = 0;

            for(int i = 0; i < GetMostProfitableData.Count; i++)
            {
                var itt = GetMostProfitableData[i];

                if(!departmentSales.ContainsKey(itt.department))
                {
                    departmentSales.Add(itt.department, itt.sales);
                }
                else if (departmentSales.ContainsKey(itt.department))
                {
                    departmentSales[itt.department] += itt.sales;
                }
            }

            foreach(var prop in departmentSales)
            {
                if(prop.Value > sales)
                {
                    sales = prop.Value;
                    theDepartment = prop.Key;
                }
            }
            return theDepartment;
        }
    }
}