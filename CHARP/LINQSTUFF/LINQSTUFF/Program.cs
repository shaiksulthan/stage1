using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSTUFF
{
    //LINQ : LANGUAGE INTEGRATED QUERY
    //LINQ OFFERS  COMMON SYNTAX FOR QUERYING ANY TYPE OF DATASOURCE : XML , COLLECTION SQL.


    class Program
    {
        class CULWords
        {
            public string LowerWord { get; set; }
            public string UpperWord { get; set; }
        }
        static void Main(string[] args)
        {
            //LINQWithIntArray();
            //LINQWithStringArray();
            //LINQWithCollection();
            string[] words = { "ManGo", "aPpLe", "BaNaNa", "StrawbeRRY", "AvOcAdO" };
            Console.WriteLine("Using Class CULWords");
            var ulwords = from w in words
                          select new CULWords()
                          {
                              LowerWord = w.ToLower(),
                              UpperWord = w.ToUpper()

                          };
            foreach (CULWords w in ulwords)
            {
                Console.WriteLine(w.LowerWord + " " + w.UpperWord);
            }

            Console.WriteLine("LINQ with Anonymous type");

            var aulwords = from w in words
                           select new
                           {
                               LowerWord = w.ToLower(),
                               UpperWord = w.ToUpper(),
                               Count = w.Length

                           };

            foreach (var w in aulwords)
            {
                Console.WriteLine(w.LowerWord + " " + w.UpperWord + " " + w.Count);
            }

            // method()
            Console.WriteLine("\nUsing Anonymous Type and Method based Query");
            var amulwords =
                words.Select(w => new { Lower = w.ToLower(), Upper = w.ToUpper() });
            foreach (var w in amulwords)
            {
                Console.WriteLine(w.Lower + " " + w.Upper);
            }

            int[] StudentsMarks = { 69, 70, 30, 45, 71, 95, 72 };
            IEnumerable<int> Score = StudentsMarks.Where(m => m >= 70).OrderBy(m => m).ThenByDescending(m => m.ToString());
            foreach (int m in Score)
                Console.WriteLine(m);
            {
            }

            List<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 },
     new Student() { StudentID = 6, StudentName = "Ram" , Age = 25 }
        };
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            foreach (Student stud in thenByResult)
            {
                Console.WriteLine(stud.StudentID + " " + stud.StudentName + " " + stud.Age);

            }

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            foreach (Student stud in thenByDescResult)
            {
                Console.WriteLine(stud.StudentID + " " + stud.StudentName + " " + stud.Age);

            }



        }

        private static void LINQWithCollection()
        {
            List<ClsProduct> ProdList = new List<ClsProduct>()
            {
                new ClsProduct() {ProdCode=111,ProdName="Laptop",ProdPrice=15000},
                new ClsProduct() {ProdCode=222,ProdName="Printer",ProdPrice=2500},
                new ClsProduct() {ProdCode=333,ProdName="Mouse",ProdPrice=250},
                new ClsProduct() {ProdCode=444,ProdName="Hard Disk",ProdPrice=3500},
                new ClsProduct() {ProdCode=555,ProdName="Scanner",ProdPrice=3000}

            };

            var lresult = ProdList.Where(x => x.ProdPrice > 1000);
            foreach (var item in lresult)
            {
                Console.WriteLine(item.ProdCode);
            }

            var result = from p in ProdList
                         where p.ProdPrice > 1000 && p.ProdName.ToLower().Contains("s")
                         select p;
            foreach (ClsProduct p in result)
            {
                Console.WriteLine(p.ProdCode + " " + p.ProdName + " " + p.ProdPrice);
            }
        }

        private static void LINQWithStringArray()
        {
            string[] StrArray = new string[] { "Sanchayeta", "Tiasa", "Venkateswarlu", "Deepthi", "Susil" };
            Console.WriteLine("NORMAL SYNTAX :");
            foreach (string str in StrArray)
            {
                if (str.ToLower().Contains("s") == true)
                {
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine("QUERY EXPRESSION :");

            var result = from str in StrArray
                         where str.StartsWith("S")
                         select str;
            foreach (string st in result)
            {
                Console.WriteLine(st);
            }
        }

        private static void LINQWithIntArray()
        {
            #region LINQ WITH INTEGER ARRAY

            int[] intArr = new int[] { -1, -2, -23, 6, 76, -5, 3 };
            Console.WriteLine("NORMAL SYNTAX :");
            foreach (int n in intArr)
            {
                if (n > 0)
                {
                    Console.WriteLine(n);
                }
            }

            Console.WriteLine("QUERY EXPRESSION :");
            // SQL : select * from the table where condition 
            // LINQ : from n in intArr
            //        where n > 0
            //        select n;

            var result = from i in intArr
                         where i > 0
                         orderby i
                         select i;

            foreach (int n in result)
            {
                Console.WriteLine(n);
            }

            #endregion
        }
    }
}
