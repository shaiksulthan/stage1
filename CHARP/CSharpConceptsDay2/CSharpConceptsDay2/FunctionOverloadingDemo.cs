using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class FunctionOverloadingDemo
    {

       static private void Area(int s)
        {
            Console.WriteLine("Area of square : {0}  square unit",s*s);

        }
        static private void Area(int l,int b)
        {
            Console.WriteLine("Area of rectangle : {0} square unit",  l*b);

        }
        static private void Area(double r)
        {
            Console.WriteLine("Area of circle  : {0} square unit", r*r*3.14);

        }
        static void Main(string[] args)
        {

            Area(45.56d);
            Area(10);
            Area(45, 64);
            
            
            ////3.0 C# , .NET FRAME 3.0 / 3.5 CLR
            //var str = Greeting();
            //Console.WriteLine(str+" "+str.GetType());
            //var a = 10;
            //Console.WriteLine(a + " " + a.GetType());
            ////a = "Abhishek";
            //// 4.0 C#  .NET FRAME 4.0 DLR PHYTHON SAS IA
            //dynamic Mydynamic = 10;
            //Console.WriteLine(Mydynamic + " " + Mydynamic.GetType());
            //Mydynamic = "Abhishek";
            //Console.WriteLine(Mydynamic + " " + Mydynamic.GetType());

        }

        static private string  Greeting()
        {
            return "HAND : Have a nice day";
        }
    }
}
