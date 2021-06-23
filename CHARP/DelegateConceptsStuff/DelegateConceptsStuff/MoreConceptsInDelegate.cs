using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConceptsStuff
{

    public delegate void Calculation(int x, int y);
    public delegate int RetCalculation(int x, int y);

    class MoreConceptsInDelegate
    {
        static int RAddition(int x, int y)
        {

            return x + y;
        }
        static int RSubstraction(int x, int y)
        {

            return x - y;
        }

        static int RMultiplication(int x, int y)
        {

            return x * y;
        }
        static int RDivision(int x, int y)
        {

            return x / y;
        }


        static void Addition(int x,int y)
        {

            Console.WriteLine("Addition of Number : {0}",x+y);
        }
        static void Substraction(int x, int y)
        {

            Console.WriteLine("Substraction of Number : {0}", x - y);
        }

       static void Multiplication(int x, int y)
        {

            Console.WriteLine("Multiplication of Number : {0}", x * y);
        }
        static void Division(int x, int y)
        {

            Console.WriteLine("Division of Number : {0}", x / y);
        }
        static void Main(string[] args)
        {
            Calculation delCal = new Calculation(Addition);
            delCal += Substraction;
            delCal += Multiplication;
            delCal += Division;

            delCal(45,56);



            RetCalculation delRCal = new RetCalculation(RAddition);
            delRCal += RSubstraction;
          
            delRCal += RDivision;
            delRCal += RMultiplication;
            int result = delRCal(45, 56);
            Console.WriteLine(result);


        }
    }
}
