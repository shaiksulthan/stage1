using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class Employee
    {
        public int EmployeeCode { get; set; }
        public string EmployeeName { get; set; }

    }

    class ObjectArrayDemo
    {
        static void Main(string[] args)
        {
            object[] ObjectArray = new object[6];
            ObjectArray[0] = 12345;
            ObjectArray[1] = 12345.67m;
            ObjectArray[2] = "FRIDAY";
            ObjectArray[3] = true;
            ObjectArray[4] = DateTime.Now;
            ObjectArray[5] = "";

            for (int i = 0; i < ObjectArray.Length; i++)
            {
                Console.WriteLine(ObjectArray[i].GetType()+" "+ObjectArray[i]);
            }

            Employee[] EmployeeList = new Employee[2];
            EmployeeList[0] = new Employee()
            {
                EmployeeCode = 1001,
                EmployeeName = "MAHANTESH"
            };
            EmployeeList[1] = new Employee()
            {
                EmployeeCode = 1002,
                EmployeeName = "SNEHA"
            };

            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine(emp.EmployeeCode+" "+emp.EmployeeName);
            }


        }

    }
}
