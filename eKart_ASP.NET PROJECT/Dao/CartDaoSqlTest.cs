using Model;
using System;

namespace Dao
{
    /// <summary>
    /// Class with test methods for Cart DAO methods
    /// </summary>
    public class CartDaoSqlTest
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Get All Cart Items");
            try
            {
                TestGetAllCartItem();
                Console.WriteLine("Add Product");
                TestAddCartItem();
                TestGetAllCartItem();
                Console.WriteLine("Remove Product");
                TestRemoveCartItem();
                TestGetAllCartItem();
            }
            catch (CartEmptyException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Test method to Get all cart items
        /// </summary>
        public static void TestGetAllCartItem()
        {
            ICartDao cartDao = new CartDaoSql();
            Cart cart = cartDao.GetAllCartItem(1);

            for (int i = 0; i < cart.ProductList.Count; ++i)
            {
                Console.WriteLine(cart.ProductList[i]);
            }
        }

        /// <summary>
        /// Test method to Add item to cart
        /// </summary>
        public static void TestAddCartItem()
        {
            ICartDao cartDao = new CartDaoSql();
            cartDao.AddCartItem(1, 1001);
        }

        /// <summary>
        /// Test method to remove item from cart
        /// </summary>
        public static void TestRemoveCartItem()
        {
            ICartDao cartDao = new CartDaoSql();
            cartDao.RemoveCartItem(1, 1001);
        }
    }
}
