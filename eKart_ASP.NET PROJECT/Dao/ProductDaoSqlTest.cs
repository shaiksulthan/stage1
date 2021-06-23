using Model;
using System;

namespace Dao
{
    public class ProductDaoSqlTest
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Product List For Admin");
            TestGetProductListAdmin();
            Console.WriteLine("Product List For Customer");
            TestGetProductListCustomer();
            Console.WriteLine("Get Product when product id is given");
            TestGetProduct();
            Console.WriteLine("Modify product");
            TestEditProduct();
        }

        public static void TestGetProductListAdmin()
        {
            IProductDao productDao = new ProductDaoSql();
            foreach (Product product in productDao.GetProductListAdmin())
            {
                Console.WriteLine(product);
            }
        }

        public static void TestGetProductListCustomer()
        {
            IProductDao productDao = new ProductDaoSql();
            foreach (Product product in productDao.GetProductListCustomer())
            {
                Console.WriteLine(product);
            }
        }

        public static void TestGetProduct()
        {
            IProductDao productDao = new ProductDaoSql();
            Console.WriteLine(productDao.GetProduct(1001));
        }

        public static void TestEditProduct()
        {
            IProductDao productDao = new ProductDaoSql();
            Product product = new Product(1001, "Redmi 7 pluse", 8999M, true,
                    Helper.ConvertToDate("15/03/2028"), "Smart Phones", true);
            productDao.ModifyProduct(product);
        }
    }
}
