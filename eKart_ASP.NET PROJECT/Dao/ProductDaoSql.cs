using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    /// <summary>
    /// Class for all Product related SQL queries
    /// </summary>
    public class ProductDaoSql : IProductDao
    {
        #region SQL queries
        public static string GET_ALL_ITEMS_ADMIN = "select * from product";
        public static string GET_ALL_ITEMS_CUSTOMER = "select * from product where pr_in_stock = 1 and pr_date_of_expiry > (select GETDATE())";
        public static string GET_PRODUCT_BY_PRODUCT_ID = "select * from product where pr_id = @Product_ID";
        public static string EDIT_PRODUCT = "update product set pr_title= @Product_Title,pr_price = @Product_Price, pr_in_stock = @Product_In_Stock, pr_date_of_expiry = @Product_DateOfExpiry, pr_category = @Product_Category,pr_free_delivery=@Product_Free_Delivery where pr_id = @Product_ID";
        #endregion

        /// <summary>
        /// Method to get all the product list for Admin role user
        /// </summary>
        /// <returns>List of products</returns>
        public IList<Product> GetProductListAdmin()
        {
            IList<Product> productList = new List<Product>();

            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = GET_ALL_ITEMS_ADMIN;

            using (sqlConn)
            {
                sqlConn.Open();
                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product product = new Product();

                    product.Id = Convert.ToInt64(dr.GetValue(dr.GetOrdinal("pr_id")));
                    product.Title = Convert.ToString(dr.GetValue(dr.GetOrdinal("pr_title")));
                    product.Price = Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("pr_price")));
                    product.InStock = (dr.GetValue(dr.GetOrdinal("pr_in_stock")).Equals("1") ? true : false);
                    product.DateOfExpiry = Convert.ToDateTime(dr.GetValue(dr.GetOrdinal("pr_date_of_expiry")));
                    product.Category = Convert.ToString(dr.GetValue(dr.GetOrdinal("pr_category")));
                    product.FreeDelivery = (dr.GetValue(dr.GetOrdinal("pr_free_delivery")).Equals("1") ? true : false);

                    productList.Add(product);
                }
            }

            return productList;
        }

        /// <summary>
        /// Method to get all the product list for Customer role user
        /// </summary>
        /// <returns></returns>
        public IList<Product> GetProductListCustomer()
        {
            IList<Product> productList = new List<Product>();

            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                Connection = sqlConn,
                CommandType = CommandType.Text,
                CommandText = GET_ALL_ITEMS_CUSTOMER
            };

            using (sqlConn)
            {
                sqlConn.Open();
                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product product = new Product();

                    product.Id = Convert.ToInt64(dr.GetValue(dr.GetOrdinal("pr_id")));
                    product.Title = Convert.ToString(dr.GetValue(dr.GetOrdinal("pr_title")));
                    product.Price = Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("pr_price")));
                    product.InStock = (dr.GetValue(dr.GetOrdinal("pr_in_stock")).Equals("1") ? true : false);
                    product.DateOfExpiry = Convert.ToDateTime(dr.GetValue(dr.GetOrdinal("pr_date_of_expiry")));
                    product.Category = Convert.ToString(dr.GetValue(dr.GetOrdinal("pr_category")));
                    product.FreeDelivery = (dr.GetValue(dr.GetOrdinal("pr_free_delivery")).Equals("1") ? true : false);

                    productList.Add(product);

                }
            }
            return productList;
        }

        /// <summary>
        /// Method to get product detail by Id
        /// </summary>
        /// <param name="productId">Required product Id</param>
        /// <returns>Product detail</returns>
        public Product GetProduct(long productId)
        {
            Product product = new Product();

            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                Connection = sqlConn,
                CommandType = CommandType.Text,
                CommandText = GET_PRODUCT_BY_PRODUCT_ID
            };

            using (sqlConn)
            {
                sqlConn.Open();
                SqlParameter parProductId = new SqlParameter("@Product_ID", SqlDbType.Int);
                parProductId.Value = productId;

                cmd.Parameters.Add(parProductId);
                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    product.Id = Convert.ToInt64(dr.GetValue(dr.GetOrdinal("pr_id")));
                    product.Title = Convert.ToString(dr.GetValue(dr.GetOrdinal("pr_title")));
                    product.Price = Convert.ToDecimal(dr.GetValue(dr.GetOrdinal("pr_price")));
                    product.InStock = (dr.GetValue(dr.GetOrdinal("pr_in_stock")).Equals("1") ? true : false);
                    product.DateOfExpiry = Convert.ToDateTime(dr.GetValue(dr.GetOrdinal("pr_date_of_expiry")));
                    product.Category = Convert.ToString(dr.GetValue(dr.GetOrdinal("pr_category")));
                    product.FreeDelivery = (dr.GetValue(dr.GetOrdinal("pr_free_delivery")).Equals("1") ? true : false);
                }
            }

            return product;
        }

        /// <summary>
        /// Method to modify a product detail
        /// </summary>
        /// <param name="product">Product object that contain the data to modify</param>
        public void ModifyProduct(Product product)
        {
            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = EDIT_PRODUCT;

            SqlParameter parProductId = new SqlParameter("@Product_ID", SqlDbType.BigInt);
            SqlParameter parProductTitle = new SqlParameter("@Product_Title", SqlDbType.VarChar, 100);
            SqlParameter parPrice = new SqlParameter("@Product_Price", SqlDbType.Decimal);
            SqlParameter parInStock = new SqlParameter("@Product_In_Stock", SqlDbType.VarChar, 3);
            SqlParameter parDateOfExpiry = new SqlParameter("@Product_DateOfExpiry", SqlDbType.DateTime);
            SqlParameter parCategory = new SqlParameter("@Product_Category", SqlDbType.VarChar, 45);
            SqlParameter parFreeDelivery = new SqlParameter("@Product_Free_Delivery", SqlDbType.VarChar, 3);

            parProductId.Value = product.Id;
            parProductTitle.Value = product.Title;
            parPrice.Value = product.Price;
            if(product.InStock == true)
            {
                parInStock.Value = "1";
            }                
            else
            {
                parInStock.Value = "0";
            }
            parDateOfExpiry.Value = product.DateOfExpiry;
            parCategory.Value = product.Category;
            if (product.FreeDelivery == true)
            {
                parFreeDelivery.Value = "1";
            }
            else
            {
                parFreeDelivery.Value = "0";
            }

            cmd.Parameters.Add(parProductId);
            cmd.Parameters.Add(parProductTitle);
            cmd.Parameters.Add(parPrice);
            cmd.Parameters.Add(parInStock);
            cmd.Parameters.Add(parDateOfExpiry);
            cmd.Parameters.Add(parCategory);
            cmd.Parameters.Add(parFreeDelivery);

            using (sqlConn)
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
