using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDLL;

namespace CSharpConceptsDay3
{
    class ConsumeCustomerDLL
    {

        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                CustomerCode = 123456,
                CustomerName = "Jantin",
                CustomerType = "Silver",
                CustomerAmount = 1200d

            };

            Console.WriteLine(customer.CustomerCode+" "+customer.CustomerName+" "+customer.CustomerAmount+" "+customer.CustomerType);
        }
    }
}
