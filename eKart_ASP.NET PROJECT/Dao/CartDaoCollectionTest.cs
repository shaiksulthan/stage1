using Model;
using System;

namespace Dao
{
    /// <summary>
    /// Class with test methods of Cart operation class
    /// </summary>
    public class CartDaoCollectionTest
    {
        public static void Main()
        {
            TestAddCartItem();
            TestRemoveCartItem();
        }

        /// <summary>
        /// Test method to add item to cart
        /// </summary>
        public static void TestAddCartItem()
        {
            ICartDao cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1, 1001);
            try
            {
                Cart cart = cartDao.GetAllCartItem(1);

                for(int i = 0; i < cart.ProductList.Count; ++i)
                {
                    Console.WriteLine(cart.ProductList[i] + "--------->" + cart.Total);
                }
            }
            catch (CartEmptyException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Test method to remove an item from cart
        /// </summary>
        public static void TestRemoveCartItem()
        {
            ICartDao cartDao = new CartDaoCollection();
            cartDao.RemoveCartItem(1, 1001);
            try
            {
                Cart cart = cartDao.GetAllCartItem(1);

                for (int i = 0; i < cart.ProductList.Count; ++i)
                {
                    Console.WriteLine(cart.ProductList[i] + "--------->" + cart.Total);
                }
            }
            catch (CartEmptyException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
