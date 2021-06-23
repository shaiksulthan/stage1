using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureStuff
{
    struct Employee2
    {
        int EmpID;
        string EmpName;
        double Salary;
        //Structs cannot contain explicit parameterless constructors  StructureStuff
        //public Employee2()
        //{

        //}

        public Employee2(int EmpID,string EmpName, double Salary)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }

        public void SetData(int EmpID, string EmpName, double Salary)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
        public int GetID()
        {
            return this.EmpID;
        }
        public string GetName()
        {
            return this.EmpName;
        }
        public double GetSalary()
        {
            return this.Salary;
        }
    }
    class STR_Emp_Methods
    {
        static void Main(string[] args)
        {
            Employee2 Emp = new Employee2();
            Emp.SetData(1001, "Arijit", 250);
            Console.WriteLine(Emp.GetID()+" "+Emp.GetName()+" "+Emp.GetSalary());
        }
    }
}
