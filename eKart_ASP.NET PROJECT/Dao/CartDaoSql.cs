using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using System.Data;

namespace Dao
{
    /// <summary>
    /// Class for all Cart related SQL queries
    /// </summary>
    public class CartDaoSql : ICartDao
    {
        #region SQL queries
        public const string ADD_PRODUCT_TO_CART = "insert into cart (ct_us_id, ct_pr_id) values (@CartUserID, @CartProductID)";
        public const string GET_PRODUCTS = "select pr_id, pr_title, pr_price, pr_in_stock, pr_date_of_expiry, pr_category, pr_free_delivery from product join cart on product.pr_id = cart.ct_pr_id where cart.ct_us_id = @CartUserID";
        public const string REMOVE_PRODUCT = "delete from cart where ct_us_id = @CartUserID and ct_pr_id = @CartProductID;";
        public const string GET_TOTAL = "select sum(pr_price) pr_price from product join cart on cart.ct_pr_id = product.pr_id where cart.ct_us_id = @CartUserID";
        #endregion

        public void AddCartItem(long userId, long productId)
        {
            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                Connection = sqlConn,
                CommandType = CommandType.Text,
                CommandText = ADD_PRODUCT_TO_CART
            };

            SqlParameter parCartUserId = new SqlParameter("@CartUserID", SqlDbType.Int);
            SqlParameter parCartProductId = new SqlParameter("@CartProductID", SqlDbType.Int);

            parCartUserId.Value = userId;
            parCartProductId.Value = productId;

            cmd.Parameters.Add(parCartUserId);
            cmd.Parameters.Add(parCartProductId);

            using (sqlConn)
            {
                sqlConn.Open();
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Method to get the cart detail by User Id
        /// </summary>
        /// <param name="userId">Input user Id</param>
        /// <returns>Cart detail</returns>
        public Cart GetAllCartItem(long userId)
        {
            Cart cart = new Cart();
            IList<Product> productList = new List<Product>();

            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                Connection = sqlConn,
                CommandType = CommandType.Text,
                CommandText = GET_PRODUCTS
            };

            using (sqlConn)
            {
                cmd.Prepare();

                SqlParameter parCartUserId = new SqlParameter("@CartUserID", SqlDbType.Int);
                parCartUserId.Direction = ParameterDirection.Input;
                parCartUserId.Value = userId;

                cmd.Parameters.Add(parCartUserId);
                sqlConn.Open();
                IDataReader dataReader = cmd.ExecuteReader();
                int count = 0;

                while (dataReader.Read())
                {
                    Product product = new Product();
                    product.Id = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal("pr_id")));
                    product.Title = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal("pr_title")));
                    product.Price = Convert.ToDecimal(dataReader.GetValue(dataReader.GetOrdinal("pr_price")));
                    product.InStock = (dataReader.GetValue(dataReader.GetOrdinal("pr_in_stock")).Equals("1") ? true : false);
                    product.DateOfExpiry = Convert.ToDateTime(dataReader.GetValue(dataReader.GetOrdinal("pr_date_of_expiry")));
                    product.Category = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal("pr_category")));
                    product.FreeDelivery = (dataReader.GetValue(dataReader.GetOrdinal("pr_free_delivery")).Equals("1") ? true : false);
                    productList.Add(product);
                    count++;
                }
                dataReader.Close();
                if (count == 0)
                {
                    throw new CartEmptyException();
                }

                cart.ProductList = productList;
                cmd.CommandText = GET_TOTAL;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(parCartUserId);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    cart.Total = Convert.ToDecimal(dataReader.GetValue(dataReader.GetOrdinal("pr_price")));
                }
            }

            return cart;
        }

        /// <summary>
        /// Remove an item from cart by User Id and Product Id
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="productId">Product Id</param>
        public void RemoveCartItem(long userId, long productId)
        {
            SqlConnection sqlConn = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                Connection = sqlConn,
                CommandType = CommandType.Text,
                CommandText = REMOVE_PRODUCT
            };

            SqlParameter parCartUserId = new SqlParameter("@CartUserID", SqlDbType.Int);
            SqlParameter parCartProductId = new SqlParameter("@CartProductID", SqlDbType.Int);

            parCartUserId.Value = userId;
            parCartProductId.Value = productId;

            cmd.Parameters.Add(parCartUserId);
            cmd.Parameters.Add(parCartProductId);

            using (sqlConn)
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
