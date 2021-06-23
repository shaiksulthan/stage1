using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class ArrayMethodDemo
    {
        static void Main(string[] args)
        {
            int[] MyNumList = new int[] { -1, -3, -2, 4, 8, -10, 12, 5, 16, 45, -11 };
            Console.WriteLine("Sort the Array :");
            Array.Sort(MyNumList);
            Console.WriteLine("After sorting :");
            foreach (int nm in MyNumList)
            {
                Console.Write(nm+" ");
            }
            Console.WriteLine("Binay search:");
            Console.WriteLine(Array.BinarySearch(MyNumList,-1));
            Console.WriteLine();
            Array.Reverse(MyNumList);

            foreach (int nm in MyNumList)
            {
                Console.Write(nm + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array Copy:");
            int[] DestinationList = new int[MyNumList.Length + 5];
            Array.Copy(MyNumList,3,DestinationList,2,MyNumList.Length-3);

            foreach (int nm in DestinationList)
            {
                Console.Write(nm + " ");
            }
            Console.WriteLine("Array Clear :");
            Array.Clear(MyNumList, 2, 5);
            foreach (int nm in MyNumList)
            {
                Console.Write(nm + " ");
            }
            Console.WriteLine();


        }
    }
}
