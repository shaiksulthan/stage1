using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay3
{

    //Internal , Internal Protected 
    //Private , Public , Protected
    //C# 3.0 WAY AUTO IMPELMENTED PROPERTY

    class FOO
    {

        private int FooCode;

        public int FooCode1 { get => FooCode; set => FooCode = value; }
    }
    class ClsEmployeeWith3_0Way
    {
        public int EmployeeCode { get; set; }//prop tab tab
        public string EmployeeName { get; set; }
        public string EmployeeDesg { get; set; }
        public string EmployeeDept { get; set; }


    }


    class ClsEmployeeWithProperties
    {
        private int empCode;
        //propfull
        public int EmpCode
        {
            get { return empCode; }
            set { empCode = value; }
        }

        private string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private string empDesg;

        public string EmpDesg
        {
            get { return empDesg; }
            set { empDesg = value; }
        }

        private string empDept;

        public string EmpDept
        {
            get { return empDept; }
            set { empDept = value; }
        }



    }


    class ClsEmployee
    {
        int empcode; // DATA MEMBER
        string empname;
        string empdesg;
        string empdept;
        public ClsEmployee()
        {

        }

        public ClsEmployee(int empcode, string empname, string empdesg, string empdept)
        {
            this.empcode = empcode;
            this.empname = empname;
            this.empdesg = empdesg;
            this.empdept = empdept;
        }
        //MEMBER FUNCTIONS / METHODS 
        public void setDetails(int empcode, string empname, string empdesg, string empdept)
        {
            this.empcode = empcode;
            this.empname = empname;
            this.empdesg = empdesg;
            this.empdept = empdept;
        }
        public void getDetails()
        {
            Console.WriteLine("CODE : {0}", empcode);
            Console.WriteLine("NAME : {0}", empname);
            Console.WriteLine("DESG : {0}", empdesg);
            Console.WriteLine("DEPT : {0}", empdept);
        }


    }
    class ClassAndObjectDemo
    {
        public static void ShowEmployeeDetails(ClsEmployeeWith3_0Way obj)
        {
            Console.WriteLine("EmpCode :{0} ,EmpName : {1} ,EmpDesg : {2} ,EmpDept :{3}", obj.EmployeeCode, obj.EmployeeName, obj.EmployeeDesg, obj.EmployeeDept);



        }

        public static ClsEmployeeWith3_0Way CreateObject (int empcode, string empname, string empdesg, string empdept)
        {
            ClsEmployeeWith3_0Way Obj30 = new ClsEmployeeWith3_0Way()
            {
                EmployeeDept = empdept,
                EmployeeCode = empcode,
                EmployeeName = empname,
                EmployeeDesg = empdesg

            };
            return Obj30;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("NORMAL WAY:");
            ClsEmployee ObjclsEmployee = new ClsEmployee();
            ObjclsEmployee.setDetails(1007, "JAMES BOND", "AGENT", "RAW");
            ObjclsEmployee.getDetails();
            ClsEmployee ObjclsEmployee1 = new ClsEmployee(1001, "Sushmika PR", "PAT", "ADM");
            ObjclsEmployee1.getDetails();

            ClsEmployeeWithProperties obj = new ClsEmployeeWithProperties();
            obj.EmpCode = 1001;
            obj.EmpName = "Nikita";

            obj.EmpDesg = "PAT";
            obj.EmpDept = "ADM";

            Console.WriteLine("EmpCode :{0} ,EmpName : {1} ,EmpDesg : {2} ,EmpDept :{3}", obj.EmpCode, obj.EmpName, obj.EmpDesg, obj.EmpDept);

            // CSHARP 3.0 WAY , OBJECT INITIALIZER

            ClsEmployeeWith3_0Way Obj30 = new ClsEmployeeWith3_0Way()
            {
                EmployeeDept = "TRAINING",
                EmployeeCode = 12345,
                EmployeeName = "ABHISHEK SHARMA",
                EmployeeDesg = "TRAINER"
                
            };
            

           
            Console.WriteLine("EmpCode :{0} ,EmpName : {1} ,EmpDesg : {2} ,EmpDept :{3}", Obj30.EmployeeCode, Obj30.EmployeeName, Obj30.EmployeeDesg, Obj30.EmployeeDept);


            ShowEmployeeDetails(Obj30);


            ClsEmployeeWith3_0Way objobj = CreateObject(1003, "Mahantesh", "PAT", "ADM");

            ShowEmployeeDetails(objobj);



        }
    }
}
