using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay5
{
    //partial : 
    //The partial keyword indicates that other parts of the class, struct,
    //or interface can be defined in the namespace.All the parts must use the
    //partial keyword.All the parts must be available at compile time to form the 
    //final type.All the parts must have the same accessibility, such as public , private , 
    //and so on
    partial class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public Employee()
        {

        }

    }

  partial  class Employee
    {
        public string ProjectName { get; set; }
        public int ProjectDuration { get; set; }

        public Employee(int EmpCode,string EmpName,string ProjectName, int ProjectDuration)
        {
            this.EmpCode = EmpCode;
            this.EmpName = EmpName;
            this.ProjectDuration = ProjectDuration;
            this.ProjectName = ProjectName;


        }
    }

    class PartialClassDemo
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee()
            {
                EmpCode = 12345,
                EmpName = "Ghoshit",
                ProjectName = "Banking",
                ProjectDuration = 40

            };
           


        }
    }
}
