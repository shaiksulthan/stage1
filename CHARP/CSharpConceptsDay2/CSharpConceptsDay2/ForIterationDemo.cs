using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class ForIterationDemo
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" "+i);
            }

            Console.WriteLine();
            Console.WriteLine("Break statement demo :");
            int c = 1;
            for (; ;)
            {
                if (c>100)
                {
                    break;
                }
                else
                {
                    Console.Write(" "+c);
                }

                c++;

            }

            Console.WriteLine("Demo of continue statement:");
            for (int i = 1; i <=10; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            c = 1;
            while (c<=100)
            {
                Console.Write(" "+c*2);
                c++;
            }

            
        }
    }
}
