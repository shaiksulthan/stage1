using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    class CollectionInitializerDemo
    {
        static void Main(string[] args)
        {

            ClsProduct obj;
            List<ClsProduct> ProdList = new List<ClsProduct>();
            //Object initializer 
            obj = new ClsProduct()
            {
                ProdCode = 111,
                ProdName = "Laptop",
                ProdPrice = 15999
            };
            ProdList.Add(obj);

            obj = new ClsProduct()
            {
                ProdCode = 222,
                ProdName = "Printer",
                ProdPrice = 2500
            };
            ProdList.Add(obj);


            obj = new ClsProduct()
            {
                ProdCode = 333,
                ProdName = "Moniter",
                ProdPrice = 5000
            };
            ProdList.Add(obj);
            Console.WriteLine("Display list by using foreach");
            foreach (ClsProduct prod in ProdList)
            {
                Console.WriteLine(prod.ProdCode + " " + prod.ProdName + " " + prod.ProdPrice);
            }

            int[] OMyMy = { 1, 2, 3, 4, 5, 6 };
            //Collection Initializer

            List<ClsProduct> ProdList2 = new List<ClsProduct>()
            {
                new ClsProduct()
            {
                ProdCode = 444,
                ProdName = "Keyboard",
                ProdPrice = 5000
            },
                 new ClsProduct()
            {
                ProdCode = 555,
                ProdName = "Joy Stick",
                ProdPrice = 1800
            },
                new ClsProduct()
            {
                ProdCode = 666,
                ProdName = "Scanner",
                ProdPrice = 3000
            }
            };

            Console.WriteLine("List of products :");
            foreach (ClsProduct prod in ProdList2)
            {
                Console.WriteLine(prod.ProdCode + " " + prod.ProdName + " " + prod.ProdPrice);
            }


        }
    }
}
