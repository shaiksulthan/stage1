using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class JaggedArrayDemo
    {

        static void Main(string[] args)
        {
            int[,,] My3DAar = new int[1, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } } };
            int[,,] My3DAar1 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 1, 2, 3 }, { 4, 5, 6 } } };
            Console.WriteLine("My3DAar Rank : {0}", My3DAar.Rank);
            Console.WriteLine("My3DAar1 Rank : {0}", My3DAar1.Rank);

            int[][] MyJaggedArray = new int[5][];
            int Counter = 1;
            Console.WriteLine("Initialize Jagged Array:" );
            Console.WriteLine(MyJaggedArray.GetLength(0));
            //Console.WriteLine(MyJaggedArray.GetLength(1));
            for (int i = 0; i < MyJaggedArray.GetLength(0); i++)
            {
                MyJaggedArray[i] = new int[i + 5];

            }
            Console.WriteLine(MyJaggedArray.Rank);

            for (int i = 0; i < MyJaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyJaggedArray[i].Length; j++)
                {
                    MyJaggedArray[i][j] = Counter++;
                }
                

            }
            Console.WriteLine("Display Jagged Array Emlements :");
            for (int i = 0; i < MyJaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyJaggedArray[i].Length; j++)
                {
                    Console.Write(MyJaggedArray[i][j]+" ");
                }
                Console.WriteLine();

            }

            int[,,,] MYMMDA = new int[2, 3, 2, 3];

            Console.WriteLine(MYMMDA.Rank);
            for (int i = 0; i < MYMMDA.Rank; i++)
            {
                Console.WriteLine("EMELEMENTS {0} : {1}",i,MYMMDA.GetLength(i));

            }


        }
    }
}