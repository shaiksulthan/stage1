using System;
using System.Globalization;

namespace Util
{
    public class Helper
    {
        public static DateTime convertToDate(String input)
        {
            // DateTime nullptr = default(DateTime);
            DateTime dateOfExpiry = default(DateTime);
            try
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                dateOfExpiry = Convert.ToDateTime(input);
                              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dateOfExpiry;
        }

        //public static ConvertUtilToSql(java.util.Date utilDate)
        //{
        //    java.sql.Date sqlDate = new java.sql.Date(utilDate.getTime());
        //    return sqlDate;
        //}
    }
}
