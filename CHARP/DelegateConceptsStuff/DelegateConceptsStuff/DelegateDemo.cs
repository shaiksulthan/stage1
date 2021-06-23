using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConceptsStuff
{
    //A DELEGATE IS A TYPE THAT REPRESENT REFERENCES TO METHOD WITH A PARTICULAR PARAMETER LIST 
    // AND RETURN TYPE
    public delegate void Greetings();
    

    class DelegateDemo
    {

        static void Show()
        {
            Console.WriteLine("1. Hello and Welcome to CTS:");
        }
        static void Display()
        {
            Console.WriteLine("2. Here we are learning delegate:");
        }
        static void Print()
        {
            Console.WriteLine("3. Have a nice day:");
        }

        static void GreetingsOfTheDay()
        {
            Show();
            Display();
            Print();

        }
        static void Main(string[] args)
        {
            //GreetingsOfTheDay();
            Console.WriteLine("SINGLE CASTING DELEGATE:");
            Greetings delGreet = new Greetings(Show);
            Console.WriteLine("MULTI CASTING :");
            //a = a + 1, a+=1 // a = a-1 , a-=1 

            delGreet += Display;
            delGreet += Print;

            delGreet();
            Console.WriteLine("DE CASTING :");

            delGreet -= Display;

            delGreet();

            Console.WriteLine("AGAIN ADDING REFERENCE :");
            delGreet += Display;
            delGreet();






        }
    }
}
