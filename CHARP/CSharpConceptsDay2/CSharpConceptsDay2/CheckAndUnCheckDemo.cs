using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class CheckAndUnCheckDemo
    {
        static readonly int x = 1000000;
        static readonly int y = 1000000;
        static int FCheck()
        {
            return checked(x * y);
        }
        static int FUnCheck()
        {
            return unchecked(x * y);
        }

        static int NoCheckAndUncheck()
        {
            return x * y;
        }
        static void Main(string[] args)
        {

            int result;
            //result = FCheck();
            //result = FUnCheck();
            result = NoCheckAndUncheck();
            Console.WriteLine(result);

        }
    }
}
