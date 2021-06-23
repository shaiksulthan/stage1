using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    //Generics Class
    public class GenPerson<INT,STRING>
    {
        INT PERSONCODE;
        STRING PERSONNAME;

        public INT PERSONCODE1 { get => PERSONCODE; set => PERSONCODE = value; }
        public STRING PERSONNAME1 { get => PERSONNAME; set => PERSONNAME = value; }

       public void ShowPersonData()
        {
            Console.WriteLine("The person Code : {0} and Person Name :{1}",PERSONCODE1,PERSONNAME1);
        }
    }
    public class GenCheck<UNKNOWDATATYPE>
    {

        public bool Compare(UNKNOWDATATYPE x, UNKNOWDATATYPE y)
        {
            if (x.Equals(y))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

    }

    //Normal Class
    public class Check
    {
        public bool Compare(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class GenericsClassDemo
    {
        static void Main(string[] args)
        {

            int a = 10, b = 20;
            bool result;
            Check chkobj = new Check();
            result = chkobj.Compare(a, b);
            Console.WriteLine("A and B are equale ? : {0}", result);


            Console.WriteLine("Comapre integer value:");
            GenCheck<int> objint = new GenCheck<int>();
            result = objint.Compare(a, b);
            Console.WriteLine("A and B are equale ? : {0}", result);
            string str1 = "Hello", str2 = "Hello";
            GenCheck<string> objstr = new GenCheck<string>();
            result = objstr.Compare(str1, str2);
            Console.WriteLine("str1 and str2 are equale ? : {0}", result);

            GenPerson<int, string> genPerson = new GenPerson<int, string>();
            genPerson.PERSONCODE1 = 1001;
            genPerson.PERSONNAME1 = "MAHANGHOSHIT";
            genPerson.ShowPersonData();







        }
    }
}
