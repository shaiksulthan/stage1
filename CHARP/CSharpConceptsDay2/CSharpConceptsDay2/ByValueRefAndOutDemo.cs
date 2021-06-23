using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class ByValueRefAndOutDemo
    {
        private static void SquareOfNumber(out int result,int number)
        {
            result = number * number;


        }

        private static void SwapByValue(int a, int b)// Formal parameter
        {
            //int t;
            //t = a;
            //a = b;
            //b = t;
            a = a * b;//a+b;
            b = a / b;//a-b;
            a = a / b;//a-b;

            Console.WriteLine("Without using third variable:");
            Console.WriteLine("After swap the values of A : {0} and B :{1}", a, b);
        }
        private static void SwapByRef(ref int a, ref int b)// Formal parameter
        {
            int t;
            t = a;
            a = b;
            b = t;
            //a = a * b;//a+b;
            //b = a / b;//a-b;
            //a = a / b;//a-b;

            //Console.WriteLine("Without using third variable:");
            //Console.WriteLine("After swap the values of A : {0} and B :{1}", a, b);
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swap the values of A : {0} and B :{1}", a, b);
            SwapByValue(a, b);// Actual Parameter

            Console.WriteLine("Actual values of A : {0} and B :{1}", a, b);

            SwapByRef(ref a,ref b);// Actual Parameter // &

            Console.WriteLine("After swap the values of A : {0} and B :{1}", a, b);

            int result;
            SquareOfNumber(out result, 25);
            Console.WriteLine("The sqaure of number : {1} is {0}",result,25);

            int r = 10;
            r = 20;
            r = 30;

            Console.WriteLine("The value of r : {0}",r);





        }

     
    }
}
