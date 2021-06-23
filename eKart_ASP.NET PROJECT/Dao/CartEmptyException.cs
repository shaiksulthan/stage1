using System;

namespace Dao
{
    /// <summary>
    /// Custom exception class when Cart is empty
    /// </summary>
    public class CartEmptyException : Exception
    {
        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public CartEmptyException()
        {

        }

        /// <summary>
        /// Exception with exception message as parameter
        /// </summary>
        /// <param name="message">Exception message</param>
        public CartEmptyException(string message) : base(message)
        {
            
        }
    }
}
