using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpConceptsDay2
{
    class Do_While_LoopDemo
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int ch;
            char cho;
            do
            {
                Console.WriteLine("----------------MENU-----------");
                Console.WriteLine("1. ADDITION");
                Console.WriteLine("2. SUBSTRACTION");
                Console.WriteLine("3. MULTIPLICATION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("5. EXIT");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("The Addition of numbers :{0}",num1+num2);
                        break;
                    case 2:
                        Console.WriteLine("The Substraction of numbers :{0}", num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("The Multiplication of numbers :{0}", num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine("The Division of numbers :{0}", num1 / num2);
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice ");
                        break;
                }
                Console.Write("Do you want to continue .....[Y/N] ? : ");
                cho = Convert.ToChar(Console.ReadLine());


            } while (cho=='Y' || cho =='y');
                
        }
    }
}
