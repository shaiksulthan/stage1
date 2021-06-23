using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureStuff
{
    struct Employee4
    {
        //C# 3.0 Features..... Auto Implememted Properties
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double  Salary { get; set; }


    }
    class Str_Emp_With_AIP_Demo
    {
        static void Main(string[] args)
        {
            Employee4 emp = new Employee4();
            emp.EmpID = 1001;
            emp.EmpName = "Deepthi";
            emp.Salary = 12345;
            Console.WriteLine(emp.EmpID + " " + emp.EmpName + " " + emp.Salary);


        }
    }
}
