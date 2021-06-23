using Model;

namespace Dao
{
    /// <summary>
    /// Interface for Cart DAO methods
    /// </summary>
    interface ICartDao
    {
        /// <summary>
        /// Method to add item to cart by User Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="productId">Product Id</param>
        void AddCartItem(long userId, long productId);

        /// <summary>
        /// Get all cart items by User Id
        /// </summary>
        /// <param name="userId">Input User Id</param>
        /// <returns>Cart detail</returns>
        Cart GetAllCartItem(long userId);

        /// <summary>
        /// Method to remove an item from Cart by User Id and Product Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="productId">Product Id</param>
        void RemoveCartItem(long userId, long productId);
    }
}
