using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsIntoDeleagteDemo
{
    class Bank
    {
        public delegate void LowBalanceHandler();
        public event LowBalanceHandler LowBalance;
        double balance;
        public double Balance
        {
            get { return balance; }
           
        }

        public double Deposite
        {
            set {
                balance += value;
            }

        }
        public double WithDraw
        {
            set
            {
                if ((balance-value)>=500)
                {
                    balance -= value;
                }
                else
                {
                    LowBalance();
                }

            }

        }







    }
}
