using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class ParamsParaDemo
    {
        static void Main(string[] args)
        {

            int a = 10, b = 20;
            AdditionOfNumbers(a, b,30,40,50,60);
        }

        private static void AdditionOfNumbers(int a, int b, params int[] k)
        {
            int tot = 0;
            Console.WriteLine("Addition Of Numbers : {0} ", a+b);
            for (int i = 0; i < k.Length; i++)
            {
                tot = tot + k[i];
            }

            Console.WriteLine("Addition Of Numbers remaining number : {0} ", tot);


        }
    }
}
