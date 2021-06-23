using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HandsOnChecking
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dob;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Adult
        {

            get
            {

                if (GetAge(dob) >= 18)
                {
                    return "Adult";
                }

                return "Child";
            }
        }
        public int GetAge(DateTime dob)
        {
            DateTime now = DateTime.Now;
            //TimeSpan ts = now - dob;
            //int Age = ts.Days/365;
            int age = now.Year - dob.Year;

            if (now.Month < dob.Month)
            {
                age--;
            }
            if (now.Month == dob.Month && now.Day < dob.Day)
                age--;
            return age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Age: " + GetAge(dob));
            Console.WriteLine(Adult);
        }
    }

    public class Progarm
    {
        public static void Main(String[] args)
        {
            string fname;
            Console.WriteLine("Enter the first name");
            fname = Console.ReadLine();

            string lname;
            Console.WriteLine("Enter the last name");
            lname = Console.ReadLine();

            DateTime dob;
            Console.WriteLine("Enter the date of birth in yyyy/mm/dd format");
            //dob = DateTime.ParseExact(Console.ReadLine(), "yyyy/mm/dd", CultureInfo.InvariantCulture);
            if (DateTime.TryParseExact(Console.ReadLine().ToString(), "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out dob))
            {
                Person person = new Person();
                person.FirstName = fname;
                person.LastName = lname;
                person.Dob = dob;
                person.DisplayDetails();

            }
            else
            {
                Console.WriteLine("Enter age is invalid:");

            }
           
          


        }
    }
}
