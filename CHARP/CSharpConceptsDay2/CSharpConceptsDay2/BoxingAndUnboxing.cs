using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class BoxingAndUnboxing
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("The value of X :{0}", x);
            object obj = x; // BOXING
            Console.WriteLine("The value of obj :{0}", obj);
            obj = 1234.56f;

            float y = (float)obj;// UN BOXING
            Console.WriteLine("The value of y : {0}",y);




        }
    }
}
