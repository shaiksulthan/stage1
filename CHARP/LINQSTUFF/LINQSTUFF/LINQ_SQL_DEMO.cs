using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSTUFF
{
    class LINQ_SQL_DEMO
    {
        static void Main(string[] args)
        {
            #region SELECT RECORD
            var db = new CustomerDBMLDataContext();

            //var result = from Customer in db.Customers
            //             select Customer;

            //foreach (var Cust in result)
            //{
            //    Console.WriteLine(Cust.CustomerID + " " + Cust.CustomerName + " " + Cust.CustomerAmount + " " + Cust.CustomerType);
            //}

            #endregion

            #region INSERTED RECORD
            //Console.WriteLine("\n INSERT RECORD INTO CUSTOMER TABLE :");

            //Customer CustObj = new Customer()
            //{
            //    CustomerID = 1004,
            //    CustomerName = "Venkatesh",
            //    CustomerAmount = 1234,
            //    CustomerType = "SILVER"

            //};

            //db.Customers.InsertOnSubmit(CustObj);
            //db.SubmitChanges();

            //var result1 = from Employee in db.EMPLOYEEs
            //              select Employee;

            // foreach (var Emp in result1)
            // {
            //     Console.WriteLine(Emp.EMPID+" "+Emp.EMPNAME+" "+Emp.EMPDESG+" "+Emp.DEPTID);
            // }
            #endregion

            #region DELETE RECORD
            //var Custo = db.Customers.Where(c => c.CustomerID == 1004).FirstOrDefault();
            //db.Customers.DeleteOnSubmit(Custo);
            //db.SubmitChanges();

            #endregion

            #region UPDATE RECORD

            var Customer = db.Customers.Where(c => c.CustomerID == 1004).FirstOrDefault();
            Customer.CustomerName = "Yendeti Venkateswarlu";
            db.SubmitChanges();



            #endregion


        }
    }
}
