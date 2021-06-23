using Model;
using System.Collections.Generic;

namespace Dao
{
    /// <summary>
    /// Interface for Product DAO class
    /// </summary>
    interface IProductDao
    {
        /// <summary>
        /// Method to get the list of products in the application for Admin role user
        /// </summary>
        /// <returns>List of products</returns>
        IList<Product> GetProductListAdmin();

        /// <summary>
        /// Method to get the list of products for Customer role user
        /// </summary>
        /// <returns>List of products</returns>
        IList<Product> GetProductListCustomer();

        /// <summary>
        /// Method to modify a product detail
        /// </summary>
        /// <param name="product">Product object that contain the data to modify</param>
        void ModifyProduct(Product product);

        /// <summary>
        /// Method to get product detail by Id
        /// </summary>
        /// <param name="productId">Required product Id</param>
        /// <returns>Product detail</returns>
        Product GetProduct(long productId);
    }
}
