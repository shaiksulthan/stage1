using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay1
{
    class ConvertAndParseDemo
    {
        static void Main(string[] args)
        {

            string str1 = "1234";
            string str2 = "1234.56";
            string str3 = null;
            string str4 = "1234464636363636464";
            string str5 = "A";

            float myFloat = 1234.567f;

            //int mynumber =(int) myFloat; // type casting
            //Console.WriteLine(mynumber);

            //mynumber = int.Parse(str3);// parsing 
            //Console.WriteLine("The value of str1  : {0}",mynumber);


            //myFloat = float.Parse(str2);
            //Console.WriteLine("The value of str2  : {0:f}", myFloat);

            int mynumber = Convert.ToInt32(str3);
            Console.WriteLine(mynumber);

            bool mybool = Convert.ToBoolean(str3); // conversion 

            Console.WriteLine(mybool);


            Boolean success;

            int result;
            success = int.TryParse(str1, out result);

            Console.WriteLine(success+" "+result);

            success = int.TryParse(str2, out result);

            Console.WriteLine(success + " " + result);



        }

    }
}
