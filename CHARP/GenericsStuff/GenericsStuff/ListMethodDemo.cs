using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    class ListMethodDemo
    {
        static void Main(string[] args)
        {
            List<string> ListOfEmployeeYear2019 = new List<string>();
            ListOfEmployeeYear2019.Add("GHOSHIT");
            ListOfEmployeeYear2019.Add("MAHANTESH");
            ListOfEmployeeYear2019.Add("TIASA");
            ListOfEmployeeYear2019.Add("VIDHI");
            ListOfEmployeeYear2019.Add("SUSIL");

            List<string> ListOfEmployeeYear2020 = new List<string>();
            ListOfEmployeeYear2020.Add("MAHANTESH");
            ListOfEmployeeYear2020.Add("DEEPTHI");
            ListOfEmployeeYear2020.Add("VIDHI");
            ListOfEmployeeYear2020.Add("SAADIA");
            ListOfEmployeeYear2020.Add("GHOSHIT");
            
            List<string> ListOfEmployeeYear2021 = new List<string>();
            ListOfEmployeeYear2021.Add("VENKY");

            ListOfEmployeeYear2021.Add("ABHISHEK");
            ListOfEmployeeYear2021.Add("VIDHI");
            ListOfEmployeeYear2021.Add("ARIJIT");
            ListOfEmployeeYear2021.Add("MAHANTESH");
         

            Console.WriteLine("listofawaitedEmployee");
            dynamic listofawaitedEmployee = ListOfEmployeeYear2019.Intersect(ListOfEmployeeYear2020).Intersect(ListOfEmployeeYear2021);
            foreach (var item in listofawaitedEmployee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
