using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpConceptsDay4
{
    // Class by default Internal // If you want this class to be access outside 
    // you to make it public
   internal class ClsFoo
    {
        // class properties or data member by default private
        // function or member function or methods are also by default private
        // Protected are similar like public , but its been used for future purpose

        int Num1;
        public int Num2;

        void show()
        {
            Console.WriteLine("The value of Num1  : {0} ", Num1);
            Console.WriteLine("The value of Num2 :{0}", Num2);
        }
        public void ShowShow()
        {
            show();
        }
        public ClsFoo()
        {

        }


    }
    class AccessmodifiersDemo
    {
        static void Main(string[] args)
        {

            ClsFoo objfoo = new ClsFoo();
            objfoo.Num2 = 2002;
            objfoo.ShowShow();
        }
    }
}
