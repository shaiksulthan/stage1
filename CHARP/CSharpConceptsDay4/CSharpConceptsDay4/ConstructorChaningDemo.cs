using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{
    class ClsPerson
    {
        private string Name;
        private string Address;
        private int Pincode;
        public ClsPerson() { }
        public ClsPerson(string Name, string Address, int Pincode)
        {
            this.Name = Name;
            this.Address = Address;
            this.Pincode = Pincode;

        }

        public void ShowPersonDetails()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Address : {0}", Address);
            Console.WriteLine("Pincode : {0}", Pincode);
        }


    }

    class ClsEmployee : ClsPerson
    {

        private int EmpID;
        private string EmpDept;
        public ClsEmployee()
        {

        }
        public ClsEmployee(string Name, string Address, int Pincode,int EmpID, string EmpDept)
            :base(Name,Address, Pincode)
        {
            this.EmpID = EmpID;
            this.EmpDept = EmpDept;
        }

        public void ShowEmployeeDetails()
        {
            ShowPersonDetails();
            Console.WriteLine("EmpID : {0}", EmpID);
            Console.WriteLine("EmpDept : {0}", EmpDept);

        }

    }
    class ClsManager : ClsEmployee
    {
        private int ProjectID;
        private string ProjectName;

        public ClsManager()
        {

        }
        public ClsManager(string Name, string Address, int Pincode, int EmpID, string EmpDept, int ProjectID, string ProjectName)
        : base(Name, Address, Pincode, EmpID, EmpDept)
        {
            this.ProjectID = ProjectID;
            this.ProjectName = ProjectName;
        }

        public void ShowManagerDetails()
        {
            ShowEmployeeDetails();
            Console.WriteLine("ProjectID : {0}", ProjectID);
            Console.WriteLine("ProjectName : {0}", ProjectName);

        }
    }

    class ConstructorChaningDemo
    {
        static void Main(string[] args)
        {
            ClsPerson clsPerson = new ClsPerson("Sanchayeta Ghosh", "Kolkata", 712136);
            clsPerson.ShowPersonDetails();
            ClsEmployee clsEmployee = new ClsEmployee("Sanchayeta Ghosh", "Kolkata",712136,1002,"PAT");
            clsEmployee.ShowEmployeeDetails();
            ClsManager clsManager = new ClsManager("Sanchayeta Ghosh", "Kolkata", 712136, 1002, "PAT", 12345, "BANKING");
            clsManager.ShowManagerDetails();
             




        }
    }
}
