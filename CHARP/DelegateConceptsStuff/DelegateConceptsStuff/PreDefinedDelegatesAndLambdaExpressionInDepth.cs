using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConceptsStuff
{
    public delegate double CalAreaPointer(int r);
    class PreDefinedDelegatesAndLambdaExpressionInDepth
    {
        public static void FuncDemo(Func<int, double> pp)
        {
            double r = pp(30);
            Console.WriteLine("The Area of circle : {0}", r);
        }
        public static void CalPoint(CalAreaPointer cp)
        {
            double d = cp(12);
            Console.WriteLine("Area of circle :  {0}", d);

        }
        public static double CalCalArea(int r)
        {
            return 3.14 * r * r;
        }

        static void Main(string[] args)
        {
            //PRE DEFINED DELEGATES 
            //Func<> : 1 RETURN AND 16 INPUTS
            //Action<> : VOID RETURN AND 16 INPUTS
            //Predicate<> : DEFINING THE CRITERIA

            CalAreaPointer cpointer = new CalAreaPointer(
                delegate (int r)
                {
                    return 3.14 * r * r;

                });

            double Area = cpointer(25);
            Console.WriteLine(Area);
            CalPoint(cpointer);//Passing delegate into function
            Console.WriteLine("Predefine delegate:");
            Func<double,double> cpointer1 = r => 3.14 * r * r;
            double result = cpointer1(12.34);
            Console.WriteLine(result);
            Console.WriteLine("By Func : {0}", cpointer1(4.31));
            Func<int, int, string> add = ((x, y) => (x + y).ToString());
            Func<int, double> calarea = r => 3.14 * r * r;
            FuncDemo(calarea);//func delegate into func
            FuncDemo(CalCalArea);//We are passing method into func


            Func<int, int, int> AdditionOfTwoNumber = ((x, y) => (x + y));
            Console.WriteLine("AdditionOfTwoNumber");
            Console.WriteLine(AdditionOfTwoNumber(10,20));

            Action<string> MyAction = y => Console.WriteLine(y);
            MyAction("I am using Action Delegate");

            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;
            Console.WriteLine(CheckGreaterThan5("Shubham"));

            List<string> NameList = new List<string>();

            NameList.Add("Jyoti");
           
            NameList.Add("Venkateshwar");
            NameList.Add("Satyanarayan");
            NameList.Add("Abneet");
            bool check = NameList.Contains("Jyoti");
            Console.WriteLine(check);

            string namename = NameList.Find(CheckGreaterThan5);
            Console.WriteLine(namename);







        }
    }
}
