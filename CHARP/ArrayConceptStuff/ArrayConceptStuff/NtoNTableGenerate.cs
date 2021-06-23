using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class NtoNTableGenerate
    {
        static void Main(string[] args)
        {
            //int End = 0, Start = 0;
            //Console.Write("Enter Starting number : ");
            //Start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Ending number : ");
            //End = Convert.ToInt32(Console.ReadLine());
            for (int i =Convert.ToInt32(args[0]); i <= Convert.ToInt32(args[1]); i++)
            {
                Console.WriteLine("\nTHE TABLE OF : {0}\n",i);

                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}",i,j,i*j);
                }
            }
            Console.WriteLine("\n");
        }
    }
}
