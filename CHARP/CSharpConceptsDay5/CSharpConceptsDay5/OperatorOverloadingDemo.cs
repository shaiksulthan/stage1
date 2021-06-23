using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay5
{

    class ClsFoo
    {
        int X;
        int Y;
        public ClsFoo()
        {

        }
        public ClsFoo(int X,int Y)
        {
            this.X = X;
            this.Y = Y;

        }
       public void Show()
        {
            Console.WriteLine("The value of X : {0}  and Y :{1}",X,Y);
        }

        //Adding propeties with help of function / Method
        public ClsFoo AddProperties(ClsFoo obj1,ClsFoo obj2)
        {

            ClsFoo obj = new ClsFoo();
            obj.X = obj1.X + obj2.X;
            obj.Y = obj1.Y + obj2.Y;
            return obj;
        }


        //Adding propeties with help of operator 
        public static ClsFoo operator +(ClsFoo obj1, ClsFoo obj2)
        {

            ClsFoo obj = new ClsFoo();
            obj.X = obj1.X + obj2.X;
            obj.Y = obj1.Y + obj2.Y;
            return obj;
        }

    }
    class OperatorOverloadingDemo
    {
        static void Main(string[] args)
        {
            ClsFoo obj1, obj2, obj;
            obj1 = new ClsFoo(10, 20);
            obj1.Show();
            obj2 = new ClsFoo(30, 40);
            obj2.Show();

            obj = new ClsFoo();
            obj = obj.AddProperties(obj1, obj2);
            obj.Show();
            //  a = 20 + 30

            obj1 = new ClsFoo(55, 65);
            obj1.Show();
            obj2 = new ClsFoo(45, 64);
            obj2.Show();
            obj = obj1 + obj2;
            obj.Show();


        }

    }
}
