using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSTUFF
{
    public class Employee
    {
        public String EmpId { get; set; }
        public String EmpName { get; set; }
        public String Designation { get; set; }
        public int Salary { get; set; }
        public Employee()
        {

        }
        public Employee(String eId, String eName, String desg, int sal)
        {
            this.EmpId = eId;
            this.EmpName = eName;
            this.Designation = desg;
            this.Salary = sal;
        }

    }

    class ConceptClearing
    {
        static void Main(string[] args)
        {


            List<Employee> EmployeeList = new List<Employee>()
            {
            new Employee("EM102", "Sally", "Manager", 55000),

            new Employee("EM103", "Merkel", "Lead",70000),

            new Employee("EM104", "Stephen", "Lead",75000),

            new Employee("EM105", "Sam", "Manager", 65000),

            new Employee("EM106", "Jose", "Lead",   50000),

            new Employee("EM107", "David", "Manager",80000)

        };


            var result = from employee in EmployeeList
                         where employee.Salary >= EmployeeList.Average(a => a.Salary)
                         select employee;
            foreach (var emp in result)
            {
                Console.WriteLine(emp.EmpId + " " + emp.EmpName + " " + emp.Designation + " " + emp.Salary);
            }

        }
    }
}





