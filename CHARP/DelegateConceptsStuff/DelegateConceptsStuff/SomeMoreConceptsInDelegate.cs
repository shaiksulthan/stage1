using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConceptsStuff
{
    public delegate int SumDel(int x, int y);
    public delegate void SumDelII(int x, int y);
    public delegate void SumOfArgument(params int[] list);
    public delegate void ShowArgument(params object[] list);
    class SomeMoreConceptsInDelegate
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("C# 1.1 Way demo :");
            SumDel delAdd = Add; // new SumDel(Add);
            Console.WriteLine("The Result :{0}", delAdd(10, 20));

            Console.WriteLine("C# 2.0  WAY - ANONYMOUS METHOD ");
            SumDelII delI = delegate (int x, int y)
            {
                Console.WriteLine("The result : {0}", x + y);
            };
            delI(55, 56);

            SumDel delII = delegate (int x, int y)
            {

                return x + y;
            };
            if (true)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Result : {0}", delII(56, 85));

            //public delegate int SumDel(int x, int y);
            //public delegate void SumDelII(int x, int y);
            //public delegate void SumOfArgument(params int[] list);
            //public delegate void ShowArgument(params object[] list);


            Console.WriteLine("C# 3.0 WAY LAMBDA EXPRESSION:");

            SumDel delIII = ((int x, int y) => (x + y)); // => goes into
            Console.WriteLine("Result : {0}", delIII(52, 63));
            SumDelII delAddII = (x, y) =>
            {
                Console.WriteLine("The result is : {0}", x + y);

            };
            delAddII(56, 54);
            int a = 1, b = 2, c = 3;
            SumOfArgument add = (int[] list) =>
            {
                int tot = 0;
                for (int i = 0; i < list.Length; i++)
                {
                    tot = tot + list[i];
                }
                Console.WriteLine("The total of number : {0}", tot);

            };

            add(a, b, c);
            add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            ShowArgument ShowList = (object[] list) =>
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.WriteLine(list[i].GetType() + " " + list[i]);
                }

            };

            ShowList(10, "Twenty", false, 123.45f, 10.01m);





        }
    }
}
