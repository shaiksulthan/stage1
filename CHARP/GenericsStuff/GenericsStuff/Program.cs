using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    class Program
    {
        static void SwapNumber(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
      
        }

        static void GenSwap<T>(ref T x, ref T y)
        {
           
            T temp;
            temp = x;
            x = y;
            y = temp;

        }
        static void Main(string[] args)
        {

            int x = 10, y = 20;
            Console.WriteLine("Before swaping  :X {0}  and Y  :{1}",x,y);
            SwapNumber(ref x,ref y);
            Console.WriteLine("After swaping : X :{0} and Y : {1}", x, y);
            float xx = 12.45f;
            Console.WriteLine("By using Generices type of function :");
            Console.WriteLine("Before swaping  :X {0}  and Y  :{1}", x, y);
            GenSwap<int>(ref x, ref y);
            Console.WriteLine("After swaping : X :{0} and Y : {1}", x, y);

            string str1 = "Flakes", str2 = "Corn";
            Console.WriteLine("Before swaping  :STR1 {0} and STR2 :{1}", str1, str2);
            GenSwap<string>(ref str1,ref str2);
            Console.WriteLine("After swaping  :STR1 {0}  and STR2 :{1}", str1, str2);




        }
    }
}
