using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt"));
            Console.WriteLine(DateTime.Now.AddDays(10));
            Console.WriteLine(DateTime.Now.ToLongDateString());

            DateTime StartDate = new DateTime(2020, 12, 11, 09, 00, 00);
            DateTime LastDate = new DateTime(2021, 01, 11, 18, 00, 00);

            TimeSpan dt = LastDate - StartDate;
            Console.WriteLine("No. of days passed : {0}", dt.Days);
            Console.WriteLine("No. of Hours passed : {0}", dt.Hours);
            Console.WriteLine("No. of Month passed : {0}", dt.Days / 30);

            Console.WriteLine(StartDate.GetType());
            int intA = 10;
            Console.WriteLine(intA + " " + intA.GetType());

            string formatString = "This is {0} overflow";
            var strVar = "stack";
            var myStr = string.Format(formatString, "stack");
            Console.WriteLine(myStr);


        }
    }
}
