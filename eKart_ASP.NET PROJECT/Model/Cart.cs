using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Model class for Cart
    /// </summary>
    public class Cart
    {
        private IList<Product> _productList;
        private decimal _total;

        /// <summary>
        /// Cart model Parameterless constructor
        /// </summary>
        public Cart()
        {

        }

        /// <summary>
        /// Cart model Constructor with 2 parameters
        /// </summary>
        /// <param name="productList">Product list to be set thru Property</param>
        /// <param name="total">Total price of items in cart</param>
        public Cart(IList<Product> productList, decimal total)
        {
            _productList = productList;
            _total = total;
        }

        #region Properties
        public IList<Product> ProductList
        {
            get
            {
                return _productList;
            }
            set
            {
                _productList = value;
            }
        }

        public decimal Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string productNames = string.Empty;
            foreach(Product product in _productList)
            {
                productNames += product.Title + ", ";
            }
            return "Cart [productList=" + productNames + ", total=" + _total + "]";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Cart other = (Cart)obj;
            if (_productList == null)
            {
                if (other._productList != null)
                    return false;
            }
            else if (!_productList.Equals(other._productList))
                return false;
            if (_total != other._total)
                return false;
            return true;
        }
        #endregion
    }
}
