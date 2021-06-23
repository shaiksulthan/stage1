using Dao;
using Model;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationToTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAdminFunctions();
            TestCustomerFunctions();            
        }

        private static void TestAdminFunctions()
        {
            Console.WriteLine("Product list Admin");
            ProductDaoCollection productDaoCollection = new ProductDaoCollection();
            IList<Product> products = productDaoCollection.GetProductListAdmin();

            Console.WriteLine("Product list Admin - Product details");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("Title: " + products[i].Title + " In stock: " + products[i].InStock + " Price: " + products[i].Price.ToString() + " Date of Expiry: " + products[i].DateOfExpiry.ToShortDateString());
            }

            Console.WriteLine("\r\n");

            Console.WriteLine("Modify the first product in the Admin list & Get the data");
            products = productDaoCollection.GetProductListAdmin();
            Product productToModify = new Product();
            productToModify = products[0];
            productToModify.Price = 100;
            productDaoCollection.ModifyProduct(productToModify);
            productToModify = productDaoCollection.GetProduct(products[0].Id);
            Console.WriteLine("Title: " + productToModify.Title + " In stock: " + productToModify.InStock + " Price: " + productToModify.Price.ToString() + " Date of Expiry: " + productToModify.DateOfExpiry.ToShortDateString());

            Console.ReadKey();
        }

        private static void TestCustomerFunctions()
        {
            ProductDaoCollection productDaoCollection = new ProductDaoCollection();
            CartDaoCollection cartDaoCollection = new CartDaoCollection();
            Cart userCart;
            IList<Product> products;

            Console.WriteLine("Product list Customer - Product names");
            products = productDaoCollection.GetProductListCustomer();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("Title: " + products[i].Title + " In stock: " + products[i].InStock + " Price: " + products[i].Price.ToString() + " Date of Expiry: " + products[i].DateOfExpiry.ToShortDateString());
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Get all cart item - Check for empty exception");

            try
            {
                userCart = cartDaoCollection.GetAllCartItem(1);
            }
            catch (CartEmptyException cartEmptyException)
            {
                Console.WriteLine(cartEmptyException.Message);
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Add item to cart & Get all cart item");

            try
            {
                cartDaoCollection.AddCartItem(1, 1002);
                userCart = cartDaoCollection.GetAllCartItem(1);
                products = userCart.ProductList;
                Console.WriteLine("\r\n");
                Console.WriteLine("Item(s) in user cart");
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine("Title: " + products[i].Title + " In stock: " + products[i].InStock + " Price: " + products[i].Price.ToString() + " Date of Expiry: " + products[i].DateOfExpiry.ToShortDateString());
                }
            }
            catch (CartEmptyException cartEmptyException)
            {
                Console.WriteLine(cartEmptyException.Message);
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Remove item from cart & Get all cart item");

            try
            {
                cartDaoCollection.RemoveCartItem(1, 1002);
                userCart = cartDaoCollection.GetAllCartItem(1);
            }
            catch (CartEmptyException cartEmptyException)
            {
                Console.WriteLine(cartEmptyException.Message);
            }

            Console.ReadKey();
        }
    }
}
