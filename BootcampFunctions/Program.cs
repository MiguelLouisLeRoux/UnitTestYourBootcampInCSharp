using System;
using System.Text.Json;

namespace BootcampFunctions
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //greeting
            var theGreet = new Greet();
            theGreet.greet("Pete");

            //transportFee
            var transport = new TransportFee();
            transport.transportFee("afternoon");

            //totalPhoneBill
            var bill = new TotalPhoneBill();
            Console.WriteLine(bill.totalPhoneBill("call, sms, call, call, sms"));

            //yearsAgo
            var ago = new YearsAgo();
            ago.yearsAgo(2014);

            //RegCheck
            var reg = new RegCheck();
            reg.regCheck("CA 202 42", "CA");

            //isWeekDay
            var day = new IsWeekDay();
            day.isWeekDay("Friday");

            //fromWhere
            var place = new FromWhere();
            place.fromWhere("CJ");

            //isFromBellville
            var bellville = new IsFromBellville();
            bellville.isFromBellville("CY 215 18");

            //countRegNumber
            var regCount = new CountRegNumber();
            regCount.countRegNumber("CA 213 45, CJ 896 451, CY 456 021, CA 321 456");

            //CountAllFromTown
            var count = new CountAllFromTown();
            count.countAllFromTown("CA 213 45, CJ 896 451, CY 456 021, CA 321 456", "CA");

            //countAllPaarl
            var paarlCount = new CountAllPaarl();
            paarlCount.countAllPaarl("CJ 345 123, CJ 2345, CL 123-546, CK 345, CJ 123, CJ 5552, CJ 9334");

            //findItemsOver20
            var itemsOver20 = new FindItemsOver20();
            itemsOver20.ItemsOver20(itemsOver20.GetItemsOverList());

            //findItemsOver
            var itemsOver = new FindItemsOver();
            itemsOver.FindItemsOverThreshold(itemsOver.GetItemsOverList(), 40);

            //mostProfitableDepartment
            var department = new MostProfitableDepartment();
            department.mostProfitableDepartment(department.GetMostProfitableData());
            
        }
    }
}