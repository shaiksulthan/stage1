using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{

    class MyOuterClass
    {
        public MyOuterClass()
        {
            Console.WriteLine("MyOuterClass");
        }
        int MyNewNumber;
        private class MyInnerClass
        {
            int MyNumber;
            public MyInnerClass()
            {
                Console.WriteLine("I am private inner class ctor :" );
            }
        }
        public void CallPrivateClass()
        {
            MyInnerClass obj = new MyInnerClass();



        }
      public class MyInnerNormalClass
        {
            public int Pincode { get; set; }
            public string City { get; set; }

            public MyInnerNormalClass()
            {
                Console.WriteLine(" I am MyInnerNormalClass :" );
            }
        }
    }


    static class MyStaticClass
    {
        static MyStaticClass()
        {

        }



    }

    class MyClass
    {
        static int i;
        string Name;
        static readonly double rate;

        static MyClass()
        {
            rate = 34.67;
        }
        public MyClass()
        {

        }

        public static void Show()
        {
            Console.WriteLine("I am static method of Myclass :");
            //rate = 35.66;

        }

        public void ShowShow()
        {
            Console.WriteLine("I am non static method of Myclass :");
            Console.WriteLine(rate);
        }


    }

    class StaticDemo
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.Show();
            myClass.ShowShow();

            Console.WriteLine();
            MyOuterClass outerClass = new MyOuterClass();

            MyOuterClass.MyInnerNormalClass ocunc = new MyOuterClass.MyInnerNormalClass();

            ocunc.Pincode = 10058;











        }
    }
}
