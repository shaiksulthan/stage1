using System;
using System.Configuration;
using System.Globalization;

namespace Dao
{
    /// <summary>
    /// Class to have all common use methods
    /// </summary>
    public static class Helper
    {
        public const string connectionStringName = "ekart";
        public const string useDatabase = "UseDatabase";

        #region Properties
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            }
        }
        #endregion

        /// <summary>
        /// Method to convert string to date
        /// </summary>
        /// <param name="dateInput">string format of date input</param>
        /// <returns>Datetime converted object</returns>
        public static DateTime ConvertToDate(string dateInput)
        {
            DateTime dateOfExpiry = default(DateTime);
            try
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                dateOfExpiry = Convert.ToDateTime(dateInput);                              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dateOfExpiry;
        }
    }
}
