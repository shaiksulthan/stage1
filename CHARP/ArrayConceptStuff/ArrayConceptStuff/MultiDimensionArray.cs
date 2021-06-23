using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class MultiDimensionArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MULTIDIMENSION:");
            int[,] MyMultiIntArray = new int[3,3];
            int Counter = 1;
            for (int i = 0; i < MyMultiIntArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyMultiIntArray.GetLength(1); j++)
                {
                    MyMultiIntArray[i, j] = Counter;
                    Counter++;
                }
            }
            Console.WriteLine("MATRIX ELEMENTS");
            for (int i = 0; i < MyMultiIntArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyMultiIntArray.GetLength(1); j++)
                {
                    Console.Write(MyMultiIntArray[i, j] + " ");
                    
                }
                Console.WriteLine();
            }

            int DiaFirst = 0;
            int DiaSecond = 0;
            for (int i = 0; i < MyMultiIntArray.GetLength(0); i++)
            {
                DiaFirst = DiaFirst + MyMultiIntArray[i, i];
            }
            Console.WriteLine();
            Console.WriteLine("First diagonal Sum : {0} ",DiaFirst);

            for (int i = 0; i < MyMultiIntArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyMultiIntArray.GetLength(1); j++)
                {
                    if (i+j==2)
                    {
                        DiaSecond = DiaSecond + MyMultiIntArray[i, j];

                    }

                }

            }
            Console.WriteLine("Second diagonal Sum : {0} ",DiaSecond);

            Console.WriteLine("DIRECT INITIALIZATION OF MULTIDIMENSIONAL ARRAY");
            int[,] MyMDIMArr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < MyMDIMArr.GetLength(0); i++)
            {
                for (int j = 0; j < MyMDIMArr.GetLength(1); j++)
                {
                    Console.Write(MyMDIMArr[i, j] + " ");

                }
                Console.WriteLine();
            }

            int[,,] My3DArr = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine(My3DArr.Rank);

        }
    }
}
