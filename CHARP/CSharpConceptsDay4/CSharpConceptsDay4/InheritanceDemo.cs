using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{
    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
        ~ A()
        {
            Console.WriteLine("A DISTRUCTOR");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }
        ~ B()
        {
            Console.WriteLine("B DISTRUCTOR");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("C");
        }
        ~ C()
        {
            Console.WriteLine("C DISTRUCTOR");
        }
    }

    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            C C = new C();


        }
    }
}
