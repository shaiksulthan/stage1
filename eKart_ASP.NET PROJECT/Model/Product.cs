using System;

namespace Model
{
    /// <summary>
    /// Model class for Product
    /// </summary>
    public class Product
    {
        private long _id;
        private string _title;
        private decimal _price;
        private bool _inStock;
        private DateTime _dateOfExpiry;
        private string _category;
        private bool _freeDelivery;

        /// <summary>
        /// Product model Parameterless constructor
        /// </summary>
        public Product()
        { }

        /// <summary>
        /// Product model Constructor with 7 parameters
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="title">Title</param>
        /// <param name="price">Price</param>
        /// <param name="inStock">In stock or not</param>
        /// <param name="dateOfExpiry">Date of expiry</param>
        /// <param name="category">Category</param>
        /// <param name="freeDelivery">Is free delivery available or not</param>
        public Product(long id, string title, decimal price, bool inStock, DateTime dateOfExpiry,
                string category, bool freeDelivery)
        {
            _id = id;
            _title = title;
            _price = price;
            _inStock = inStock;
            _dateOfExpiry = dateOfExpiry;
            _category = category;
            _freeDelivery = freeDelivery;
        }

        #region Properties
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public bool InStock
        {
            get
            {
                return _inStock;
            }
            set
            {
                _inStock = value;
            }
        }

        public DateTime DateOfExpiry
        {
            get
            {
                return _dateOfExpiry;
            }
            set
            {
                _dateOfExpiry = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public bool FreeDelivery
        {
            get
            {
                return _freeDelivery;
            }
            set
            {
                _freeDelivery = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Product [id=" + _id + ", title=" + _title + ", price=" + _price + ", inStock="
                    + _inStock + ", dateOfExpiry=" + _dateOfExpiry + ", Category=" + _category
                    + ", freeDelivery=" + _freeDelivery + "]";
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            Product other = (Product)obj;
            if (_id != other._id)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
