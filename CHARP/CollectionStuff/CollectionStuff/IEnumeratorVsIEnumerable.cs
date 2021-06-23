using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStuff
{
    class IEnumeratorVsIEnumerable
    {
        static void Main(string[] args)
        {
            ArrayList YearList = new ArrayList();
            YearList.Add(1997);
            YearList.Add(1998);
            YearList.Add(1999);
            YearList.Add(2000);
            YearList.Add(2001);
            YearList.Add(2002);
            YearList.Add(2003);
            YearList.Add(2004);
            YearList.Add(2005);
            YearList.Add(2006);
            YearList.Add(2007);
            Console.WriteLine("List of year :");
            foreach (int year in YearList)
            {
                Console.WriteLine(year);
            }
            //IEnumerable is sugar coating on IEnumerator
            //IEnumerable internally using  IEnumerator
            Console.WriteLine("By using IEnumerable");
            IEnumerable ienum = (IEnumerable)YearList;
            Iterate1997to2002(ienum);
            Console.WriteLine("By using IEnumerator");
            //IEnumerator is remember the state
            //IEnumerator ien = YearList.GetEnumerator();
            //EnumIterate1997to2002(ien);


        }
        static void EnumIterate1997to2002(IEnumerator year)
        {
            Console.WriteLine("Iterate values to from 1997 to 2002:");
            while (year.MoveNext())
            {
                Console.WriteLine(year.Current);
                if (Convert.ToInt32(year.Current) > 2001)
                {
                    EnumIterate2003to2007(year);
                }
            }


        }
        static void EnumIterate2003to2007(IEnumerator year)
        {
            Console.WriteLine("Iterate values to from 2003 to 2007:");
            while (year.MoveNext())
            {
                Console.WriteLine(year.Current);

            }

        }
        static void Iterate1997to2002(IEnumerable year)
        {
            Console.WriteLine("Iterate values to from 1997 to 2002:");
            foreach (int y in year)
            {
                Console.WriteLine(y);
                if (y > 2002)
                {
                    Iterate2003to2007(year);
                }
            }

        }
        static void Iterate2003to2007(IEnumerable year)
        {
            Console.WriteLine("Iterate values to from 2003 to 2007:");
            foreach (int y in year)
            {
                Console.WriteLine(y);

            }

        }


    }
}
