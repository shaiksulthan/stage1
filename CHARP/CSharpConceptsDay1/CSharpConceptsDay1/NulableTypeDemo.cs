using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay1
{
    class NulableTypeDemo
    {
        static void Main(string[] args)
        {

            int myint = 123;

            //int intA = null;
            int? intB = null; // ? the way of declaring nullable type

            intB = 123445;

            int result = intB ?? 10;
            Console.WriteLine(result);


        }
    }
}
