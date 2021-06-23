using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ns = CSharpConceptsDay4.OuterNamespace.InnerNamespace;

namespace CSharpConceptsDay4
{
    namespace OuterNamespace 
    {
        class Foo
        {
            public Foo()
            {
                Console.WriteLine("I am outer foo class:");
            }
        }
        namespace InnerNamespace
        {
            class InnerClass
            {
                public InnerClass()
                {
                    Console.WriteLine("I am in InnerClass:");
                }
            }

            class Foo
            {
                public Foo()
                {
                    Console.WriteLine("I am Inner Namespace foo class:");
                }
            }
        }


    }

    class NamespaceDemo
    {
        static void Main(string[] args)
        {
            OuterNamespace.Foo FooOBJ = new OuterNamespace.Foo();
            OuterNamespace.InnerNamespace.InnerClass innerClass = new OuterNamespace.InnerNamespace.InnerClass();
            OuterNamespace.InnerNamespace.Foo foo = new OuterNamespace.InnerNamespace.Foo();
            ns.Foo foo1 = new ns.Foo();
            

        }
    }
}
