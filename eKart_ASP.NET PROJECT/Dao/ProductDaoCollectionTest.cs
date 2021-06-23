using Model;
using System;

namespace Dao
{
    /// <summary>
    /// Class with test methods of Product operation class
    /// </summary>
    public class ProductDaoCollectionTest
    {
        public static void Main()
        {
            Console.WriteLine("ProductDaoCollectionImplTest");
            TestModifyProduct();
            TestGetProductListAdmin();
            TestGetProductListCustomer();
        }

        /// <summary>
        /// Test method to modify product detail
        /// </summary>
        public static void TestModifyProduct()
        {
            Console.WriteLine("ModifyProduct is called ");
            Product product = new Product(1001, "Redmi 7 Pro", 8999.00M, true,
                    Helper.ConvertToDate("15/03/2028"), "Smart Phones", true);
            Console.WriteLine("New product to be added -->" + product);
            IProductDao productDao = new ProductDaoCollection();
            productDao.ModifyProduct(product);
            Console.WriteLine("Modified Products");
            foreach (Product products in productDao.GetProductListAdmin())
            {
                Console.WriteLine(products);
            }
            Console.WriteLine("New Product->" + productDao.GetProduct(product.Id));
        }

        /// <summary>
        /// Test method to get the product list for admin role user
        /// </summary>
        public static void TestGetProductListAdmin()
        {
            Console.WriteLine("Get Product List is called ");
            IProductDao productDao = new ProductDaoCollection();
            foreach (Product product in productDao.GetProductListAdmin())
            {
                Console.WriteLine(product);
            }
        }

        /// <summary>
        /// Test method to get the product list for customer role user
        /// </summary>
        public static void TestGetProductListCustomer()
        {
            Console.WriteLine("Get Product List Customer is called");
            IProductDao productDao = new ProductDaoCollection();
            foreach (Product product in productDao.GetProductListCustomer())
            {
                Console.WriteLine(product);
            }
        }
    }
}
