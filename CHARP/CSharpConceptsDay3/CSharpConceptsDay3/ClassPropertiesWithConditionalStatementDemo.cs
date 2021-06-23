using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay3
{
    class ClsAccount
    {
        public ClsAccount()
        {
            balance = 5000;

        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            //set { balance = value; }
        }
        
        public double Deposite
        {
            set
            {
                balance += value;
            }

        }
        public double Withdraw
        {
            set
            {
                if ((balance - value) >= 1000)
                    balance -= value;
                else
                    Console.WriteLine("Insufficient Balance:");

            }


        }




    }


    class ClassPropertiesWithConditionalStatementDemo
    {
        static void Main(string[] args)
        {
            ClsAccount account = new ClsAccount();
            Console.WriteLine("Account balance : {0}",account.Balance);
            Console.WriteLine("Let's deposite 1000 /- Rs in an account:");
            account.Deposite = 1000;
            Console.WriteLine("After deposite Account balance : {0}", account.Balance);
            Console.WriteLine("Let's withdraw money from an account:");
            account.Withdraw = 4500;
            Console.WriteLine("After withdraw Account balance : {0}", account.Balance);

            account.Withdraw = 1200;
            Console.WriteLine("After withdraw Account balance : {0}", account.Balance);


        }
    }
}
