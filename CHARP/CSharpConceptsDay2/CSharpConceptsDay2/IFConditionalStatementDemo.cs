using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class IFConditionalStatementDemo
    {

        static void Main(string[] args)
        {
            #region IF STATEMENT DEMO
            Console.WriteLine("Enter any character :");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            if (ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' )
            {
                Console.WriteLine("The character is vowel : {0}",ch);
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion
            #region IF ELSE IF LADDER
            int a = 10, b = 20, c = 30;
            if (a>b && a>c)
            {
                Console.WriteLine("A is greater :");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("B is greater :");
            }
            else
            {

                Console.WriteLine("C is greater :");
            }
            #endregion
            #region NESTED IF CONDITION

            int Age = 18;
            if (Age >= 18)
            {
                if (Age>=60)
                {
                    Console.WriteLine("YOU ARE SENIOR CETIZEN:");

                }
                else
                {
                    Console.WriteLine("YOU ARE MAJOR:");
                }
            }
            else
            {

                Console.WriteLine("YOU ARE MINOR :");
                Console.WriteLine("GOTO ISKOOL:");
            }
            #endregion
        }
    }
}
