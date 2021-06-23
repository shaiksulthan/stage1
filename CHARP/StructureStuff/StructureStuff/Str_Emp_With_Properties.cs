using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureStuff
{
    //class Foo
    //{
    //    public Foo()
    //    {
    //        Console.WriteLine("I am from Foo class:");
    //    }
    //}
    public abstract class AFoo
    {

        public abstract void show();

    }

   interface IFoo
    {
        int SapID { get; set; }
    }
    struct Employee3 : IFoo
    {

        private int _EmpId;

        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }
        private string _EmpName;

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        private double  _Salary;

        public double  Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        public int SapID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Str_Emp_With_Properties
    {
        static void Main(string[] args)
        {
            Employee3 employee = new Employee3();
            employee.EmpId= 12345;
            employee.EmpName = "Dheeraj";
            employee.Salary = 1234;
            Console.WriteLine();
            Console.WriteLine(employee.EmpId + " " + employee.EmpName + " " + employee.Salary);
        }
    }
}
