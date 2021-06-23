using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    class GenericsCollectionDemo
    {
        static void Main(string[] args)
        {
            ArrayList Alist = new ArrayList();
            Alist.Add(10);
            Alist.Add(20);
            //Alist.Add("Thirty");
            Alist.Add(40);
            Console.WriteLine("List of Elements :");
            foreach (int itn in Alist)
            {
                Console.WriteLine(itn);
            }


            List<int> IntList = new List<int>();
            IntList.Add(10);
            IntList.Add(20);
            //IntList.Add("Thirty");// Cannot convert from 'string' to 'int'   
            IntList.Add(30);
            IntList.Add(40);
            foreach (int n in IntList)
            {
                Console.WriteLine(n);
            }
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            Dict.Add(".txt", "Notepad.exe");
            Dict.Add(".rtf", "Wordpad.exe");
            Dict.Add(".doc", "Winword.exe");
            Dict.Add(".bmp", "mspaint.exe");
            Dict.Add("control", "control panel");
            Dict.Add("appwiz.cpl", "add and remove program");
            Console.WriteLine("Key Value : {0}", Dict[".txt"]);
            //Dict[".txt"] = "Hello Hello";
            //Console.WriteLine("Key Value : {0}", Dict[".txt"]);

            Console.WriteLine("By using foreach :");
            foreach (KeyValuePair<string, string> kvp in Dict)
            {
                Console.WriteLine("Key :{0} and Value :{1}", kvp.Key, kvp.Value);

            }

            Console.WriteLine("Keys from Dictionary :");
            foreach (string k in Dict.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Values from Dictionary :");
            foreach (string v in Dict.Values)
            {
                Console.WriteLine(v);
            }

            Dictionary<int, string> Dict2 = new Dictionary<int, string>();

           





        }
    }
}
