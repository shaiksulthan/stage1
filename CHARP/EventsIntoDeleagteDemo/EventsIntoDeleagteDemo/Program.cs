using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsIntoDeleagteDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank HDFC = new Bank();
            HDFC.LowBalance += HDFC_LowBalance;
            HDFC.Deposite = 5000;
            Console.WriteLine("After Deposite balance : {0}",HDFC.Balance);
            Console.WriteLine("Let's WithDraw 4700 ");
            HDFC.WithDraw = 4700;
            Console.WriteLine("After Withdraw balance : {0}", HDFC.Balance);
            Bank ICICI = new Bank();
            ICICI.LowBalance += ICICI_LowBalance;

            Console.WriteLine("Doing transaction with ICICI :" );

            ICICI.Deposite = 5000;
            Console.WriteLine("After Deposite balance : {0}", ICICI.Balance);
            Console.WriteLine("Let's WithDraw 4500 ");
            ICICI.WithDraw = 4500;
            Console.WriteLine("After Withdraw balance : {0}", ICICI.Balance);

            Console.WriteLine("Let's WithDraw 500 ");
            ICICI.WithDraw = 500;
            Console.WriteLine("After Withdraw balance : {0}", ICICI.Balance);
        }

        private static void ICICI_LowBalance()
        {
            Console.WriteLine("No....No...Money as i said:");
        }

        private static void HDFC_LowBalance()
        {
            Console.WriteLine("Insufficient Balance:");
        }
    }
}
