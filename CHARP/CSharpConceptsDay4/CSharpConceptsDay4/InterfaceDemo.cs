using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{
    //Every thing inside the interface , its a public 
   

    interface ICOLDCustomer
    {
         int MyProperty { get; set; }
        void ShowCustomerDatails();// By default abstract
    }


    abstract class MyABSClass : ICOLDCustomer
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void ShowCustomerDatails();
        //public void ShowCustomerDatails()
        //{
        //    throw new NotImplementedException();
        //}
    }
    interface ICustomer : ICOLDCustomer
    {
        int CustomerCode { get; set; }
        //string Name; Interface not allowed instance field
        new void ShowCustomerDatails();// By default abstract

    }
    class CLSCustomer : ICustomer//, ICOLDCustomer
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ICustomer.CustomerCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowCustomerDatails()
        {
            throw new NotImplementedException();
        }

        //public void ShowCustomerDatails()
        //{
        //    throw new NotImplementedException();
        //}

        //void ICOLDCustomer.ShowCustomerDatails()
        //{
        //    throw new NotImplementedException();
        //}
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {

        }
    }
}
