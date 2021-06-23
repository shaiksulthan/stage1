using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class PointerAndUnSafeCode
    {
       unsafe static void NumberSquare(int* p)
        {
            // a= a+1
            // a+=a
            //a*=a
            *p *= *p;

        }
        static void Main(string[] args)
        {
            unsafe
            {
                int num = 5;
                NumberSquare(&num);
                Console.WriteLine("The square of number is {0} ",num);
            }


        }
    }
}
