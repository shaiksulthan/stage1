using Model;
using System.Collections.Generic;

namespace Dao
{
    /// <summary>
    /// Class for all Cart related operations
    /// </summary>
    public class CartDaoCollection : ICartDao
    {
        private static Dictionary<long, Cart> _cart;

        /// <summary>
        /// Constructor
        /// </summary>
        public CartDaoCollection()
        {
            if (_cart == null)
            {
                _cart = new Dictionary<long, Cart>();
            }
        }

        /// <summary>
        /// Get all cart items by User Id
        /// </summary>
        /// <param name="userId">Input User Id</param>
        /// <returns>Cart detail</returns>
        public Cart GetAllCartItem(long userId)
        {
            Cart cart = new Cart();
            bool success = _cart.TryGetValue(userId, out cart);

            if (cart == null || cart.ProductList.Count == 0)
            {
                throw new CartEmptyException("No item in cart");
            }

            if (success)
            {
                IList<Product> productList = cart.ProductList;
                decimal totalPrice = 0;
                foreach (Product product in productList)
                {
                    totalPrice += product.Price;
                }

                cart.Total = totalPrice;

            }
            return cart;
        }

        /// <summary>
        /// Method to remove an item from Cart by User Id and Product Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="productId">Product Id</param>
        public void RemoveCartItem(long userId, long productId)
        {
            IList<Product> productList = _cart[userId].ProductList;

            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].Id == productId)
                {
                    productList.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Method to add item to cart by User Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="productId">Product Id</param>
        public void AddCartItem(long userId, long productId)
        {
            IProductDao productDao = new ProductDaoCollection();
            Product product = productDao.GetProduct(productId);
            if (_cart.ContainsKey(userId))
            {
                _cart[userId].ProductList.Add(product);
            }
            else
            {
                Cart newCart = new Cart();
                IList<Product> products = new List<Product>();
                products.Add(product);
                newCart.ProductList = products;
                _cart.Add(userId, newCart);
            }
        }
    }
}
