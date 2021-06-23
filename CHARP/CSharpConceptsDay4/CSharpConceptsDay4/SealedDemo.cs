using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{
    class CLSProduct
    {
        public virtual void ProductList()
        {
            Console.WriteLine("I have details of items:");
        }

    }
    //sealed class CLSConsumer
  class CLSConsumer : CLSProduct
    {
        //sealed public override void ProductList()
        public override void ProductList()
        {
            Console.WriteLine("I having same details of items: what cls product have");
        }

        public virtual void NewProductList()
        {
            Console.WriteLine("I having same details of new items: what cls product have");
        }

    }
    class CLSEndUser : CLSConsumer
    {
        public override void ProductList()
        {
            Console.WriteLine("I having same same details of items: what cls product have coppied");
        }

        public override void NewProductList()
        {
            Console.WriteLine("I having same details of new items: what cls product have");
        }
    }

    class SealedDemo
    {
        static void Main(string[] args)
        {
            CLSEndUser obj = new CLSEndUser();
            obj.ProductList();
        }
    }
}
