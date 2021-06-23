using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class EnumDemo
    {
        public enum days { sun = -1, mon, tue, wed, thu, fri, sat };
        enum Range : long { Max = 9223372036854775807L,Min= 254L }
        static void Main(string[] args)
        {
            int x = (int)days.sun;
            Console.WriteLine("Sunday is :{0}",x);
            Console.WriteLine("Monday is :{0}", (int)days.mon);
            Console.WriteLine(long.MaxValue+" "+long.MinValue);

            long a = (long)Range.Max;
            Console.WriteLine("MAX : {0} ",a);
            long m = (long)Range.Min;
            Console.WriteLine("MIN : {0} ", m);

            int mm = unchecked((int)Range.Max);
            Console.WriteLine(mm);




        }

    }
}
