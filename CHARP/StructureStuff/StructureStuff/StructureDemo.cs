using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureStuff
{
    struct Employee
    {
        public int EmpID;
        public string EmpName;
        public double Salary;

    }
    class StructureDemo
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp.EmpID = 1001;
            emp.EmpName = "Anoushka";
            emp.Salary = 1500;
            ShowEmployeeDetails(emp);

        }

        private static void ShowEmployeeDetails(Employee emp)
        {
            Console.WriteLine("The Employee ID :{0} , Name : {1} and Salary : {2}", emp.EmpID, emp.EmpName, emp.Salary);
        }
    }
}
