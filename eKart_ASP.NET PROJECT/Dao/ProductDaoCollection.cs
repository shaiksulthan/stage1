using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dao
{
    /// <summary>
    /// Class for all Product related operations
    /// </summary>
    public class ProductDaoCollection : IProductDao
    {
        private static IList<Product> _productList;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductDaoCollection()
        {
            if (_productList == null)
            {
                _productList = new List<Product>();
                Product product1 = new Product(1001, "Redmi 6 Pro", 8999M, true,
                        Helper.ConvertToDate("03/15/2028"), "Mobile", true);
                Product product2 = new Product(1002, "Redmi 6 Pro", 8999.00M, true,
                        Helper.ConvertToDate("12/23/2028"), "Mobile", true);
                Product product3 = new Product(1003, "Pringles Potato Chips 110g", 97.99M, true,
                        Helper.ConvertToDate("08/21/2019"), "Snack Foods", false);
                Product product4 = new Product(1004, "Samsung 43 LED Smart TV", 45999.00M, false,
                        Helper.ConvertToDate("07/02/2031"), "Electronics", true);
                Product product5 = new Product(1004, "Nikon D5600 DSLR", 48199.00M, true,
                        Helper.ConvertToDate("07/06/2031"), "Electronics", true);
                _productList.Add(product1);
                _productList.Add(product2);
                _productList.Add(product3);
                _productList.Add(product4);
                _productList.Add(product5);
            }
        }

        /// <summary>
        /// Method to get the list of products in the application for Admin role user
        /// </summary>
        /// <returns>List of products</returns>
        public IList<Product> GetProductListAdmin()
        {
            return _productList;
        }

        /// <summary>
        /// Method to get the list of products for Customer role user
        /// </summary>
        /// <returns>List of products</returns>
        public IList<Product> GetProductListCustomer()
        {
            IList<Product> filteredProductList = new List<Product>();
            foreach (Product product in _productList)
            {
                if (product.DateOfExpiry > DateTime.Now && product.InStock)
                {
                    filteredProductList.Add(product);
                }
            }
            return filteredProductList;
        }

        /// <summary>
        /// Method to modify a product detail
        /// </summary>
        /// <param name="product">Product object that contain the data to modify</param>
        public void ModifyProduct(Product product)
        {
            for (int i = 0; i < _productList.Count; i++)
            {
                if (_productList[i].Id == product.Id)
                {
                    _productList[i] = product;
                }
            }
        }

        /// <summary>
        /// Method to get product detail by Id
        /// </summary>
        /// <param name="productId">Required product Id</param>
        /// <returns>Product detail</returns>
        public Product GetProduct(long productId)
        {
            if(_productList.Where(iter => iter.Id == productId).Count() > 0)
            {
                return _productList.Where(iter => iter.Id == productId).FirstOrDefault();
            }
            return null;
        }
    }
}
