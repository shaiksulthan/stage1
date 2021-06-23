using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GarbageCollectorConceptsDemo
{
    //We implement a Dispose method to release 
    //unmanaged resources used by your application.
    //The.NET garbage collector does not allocate or release unmanaged memory.
    //The pattern for disposing an object,referred to as a dispose pattern,
    //imposes order on the lifetime of an object.
    class Foo : IDisposable
    {
        private int X;
        public Foo() {
            Console.WriteLine("{0}  I am Constructor will allocate or Initialize class object:", X);
        }
        public Foo(int X)
        {
            this.X = X;
            Console.WriteLine("{0}  I am Constructor will allocate or Initialize class object:", X);
        }
        public void Show()
        {
            Console.WriteLine("The values of X :{0}", X);
        }

        public void Dispose()
        {
            Console.WriteLine("Clean up Unmanaged Resource");
            GC.SuppressFinalize(this);//Finalize distructor in VB.NET
        }

        ~Foo()
        {
            Console.WriteLine("{0}  I am distructor will free refernce object:", X);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Foo obj1 = new Foo(1);
            //Foo obj2 = new Foo(2);

            //Foo FooObj = new ClsFoo();
            //Foo FooObj = new ClsFoo();


            using (Foo FooObj = new Foo(1))
            {

                FooObj.Show();
            }
            Console.WriteLine();

            using (Foo FooObj = new Foo(1))
            {

                FooObj.Show();
            }
            SqlConnection con = new SqlConnection();


            using (SqlCommand com = new SqlCommand(" ", con))
            {

            }



        }
    }
}
