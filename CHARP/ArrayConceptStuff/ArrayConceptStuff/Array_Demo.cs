using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class Array_Demo
    {
        static void Main(string[] args)
        {

            // int MyArray[5] C,C++ way, Array is value type in c lang.

            //SINGLE DIMENSION ARRAY
            Console.WriteLine("Working with integer Array:");
            int[] MyIntArray = new int[5];
            //Initialization of Array
            for (int i = 0; i < MyIntArray.Length; i++)
            {
                MyIntArray[i] = i + 1;
            }
            //Displaying the elements of Array
            Console.WriteLine("Elements of integer Array : Using For");
            for (int i = 0; i < MyIntArray.Length; i++)
            {
                Console.WriteLine(MyIntArray[i]);
            }

            Console.WriteLine("By Using for each loop :");
            foreach (var nm in MyIntArray)
            {
                Console.Write(" " + nm);
            }
            Console.WriteLine();

            Console.WriteLine("DIRECT INITIALIZATION OF ARRAY");

            //LHS = RHS

            int[] MyIntArr = { 1, 2, 3, 4, 5 };
            foreach (var nm in MyIntArr)
            {
                Console.Write(" " + nm);
            }
            Console.WriteLine();

            Console.WriteLine("Working With string type of Array :");
            string[] MyStringArray = new string[5];
            MyStringArray[0] = "MOULI CHANDRA";
            MyStringArray[1] = "Mani Deepthi";
            MyStringArray[2] = "MAHANTESH";
            MyStringArray[3] = "Sneha";
            MyStringArray[4] = "Yogesh";

            Console.WriteLine("\n NAME LIST : \n");
            char[] strArr;
            for (int i = 0; i < MyStringArray.Length; i++)
            {
                Console.Write(MyStringArray[i] + " : ");
                strArr = MyStringArray[i].ToCharArray();
                foreach (var str in strArr)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();


            }

            int[] My100ELEARRAY = new int[100];
            for (int i = 0; i < My100ELEARRAY.Length; i++)
            {
                My100ELEARRAY[i] = i + 1;
            }
            Console.WriteLine("100 ELEMENTS ARRAY :");
            for (int i = 0; i < My100ELEARRAY.Length; i++)
            {
                Console.Write(My100ELEARRAY[i] + " ");
            }

            Display(My100ELEARRAY);
            Console.WriteLine();



        }

        private static int Display(int[] My100ELEARRAY)
        {
            for (int i = 0; i < My100ELEARRAY.Length; i++)
            {
                Console.Write(My100ELEARRAY[i] + " ");
            }
            return 0;
        }
    }
}
