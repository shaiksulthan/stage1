using System;
using System.Collections.Generic;//  ctrl+k+c
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay1
{
    class IntroductionOfdatatypes
    {
        static void Main(string[] args)
        {
            int Code = 1001;
            string Name = "ABHISHEK";
            float SigningAmount = 12003.1234f;
            bool ActiveStatus = true;
            Console.WriteLine("Code : "+Code+"Name :"+Name+ " SigningAmount : "+SigningAmount+ " ActiveStatus : "+ActiveStatus);
            Console.WriteLine("CODDE : {0} , NAME :{1} , SigningAmount : {2} , ActiveStatus :{3}",Code,Name,SigningAmount,ActiveStatus);

            Int16 MyInt32 = 12345;
           
            Decimal MyDecimal = 1234.56m;
            Single MySingle = 12345.577f;
          
            

            Console.WriteLine("Integer : MIN {0} and MAX {1}",int.MinValue,int.MaxValue);
            Console.WriteLine("Integer : MIN {0} and MAX {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("Integer : MIN {0} and MAX {1}", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("Decimal : MIN {0} and MAX {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("Float : MIN {0} and MAX {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Double : MIN {0} and MAX {1}", double.MinValue, double.MaxValue);
                       
            UInt16 MyInt16 =32769;

            Console.WriteLine("Un Int16 : MyInt16 {0}", MyInt16);


            Console.WriteLine();

            // console combination of input and output

            Console.Write("Hello and Welcome to Cognizant");// \n
            Console.WriteLine("We are learning C#"); // CTRL + F5



            //Console.ReadLine();

           
            



        }
    }
}
