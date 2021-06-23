using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay1
{
    class InputInCSharp
    {
        static void Main(string[] args)
        {
            int EMPCODE;
            string NAME;
            decimal SALARY;
            bool ACTIVESTATUS;
            Console.Write("Enter Employee Code : ");
            EMPCODE =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            NAME = Console.ReadLine();
            Console.Write("Enter Employee Salary :");
            SALARY =Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Employee ACTIVESTATUS : [true / false] ");
            ACTIVESTATUS = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("EMPCODE : {0} , NAME :{1} , SALARY : {2} , ACTIVESTATUS :{3}", EMPCODE, NAME, SALARY, ACTIVESTATUS);


            Console.WriteLine("Console.ReadLine : Enter any number");
            int number =int.Parse(Console.ReadLine());
            
            Console.WriteLine("Console.ReadKey : Enter any Key");
            ConsoleKeyInfo Key = Console.ReadKey();
            Console.WriteLine("The key you have pressed"+ Key.Key);

            Console.WriteLine("Console.Read : Enter single key");
            int numchar = Console.Read();
            Console.WriteLine("The key you have pressed" + numchar.ToString());












        }

    }
}
