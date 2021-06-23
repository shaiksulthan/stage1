using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{
    //
    // Abstract : Is a summary of the contents of a book, article, or speech.
    // Abstract : class always use as a base class for any project or standard class.
    // Abstract : Abstract class can also abstract method 
    // Abstract : Abstract class cannot be instancetiated.

    //class MyBaseClass
    //{
    //    public void SayHello()
    //    {

    //    }
    //    //public abstract void showMe();

    //}

    abstract class MyFirstABS //: MyBaseClass
    {
        public abstract void Hello();
        public void NormalMethod()
        {
            Console.WriteLine("I am normal class method");

        }


    }
    abstract class MySecondABS :MyFirstABS
    {


    }


    abstract class MyAbs
    {
        public MyAbs()
        {
            Console.WriteLine("My abs class :");
        }

    }
    abstract class AbsEmployee
    {
        private int NoofLeaveTaken;
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }

        public AbsEmployee()
        {
            NoofLeaveTaken = 0;
        }

        public abstract void ShowLeaveDetails();

        public void ShowDetails()
        {
            Console.WriteLine("Employee details are as follows :");
        }




    }

    class Employee : MySecondABS
    {
        public override void Hello()
        {
            Console.WriteLine("I am Employee Hello:");
        }

       
    }

    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            MyFirstABS myFirstABS = new Employee(); //obj;
            myFirstABS.Hello();

            // AbsEmployee absEmployee = new AbsEmployee();it's not allowed
        }
    }
}
