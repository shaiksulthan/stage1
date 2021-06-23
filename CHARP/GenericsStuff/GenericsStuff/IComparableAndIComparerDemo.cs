using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    class CompareByName : IComparer<ClsPerson>
    {
        public int Compare(ClsPerson x, ClsPerson y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
    class CompareByAge : IComparer<ClsPerson>
    {
        public int Compare(ClsPerson x, ClsPerson y)
        {
            //Equale 0
            if (x.Age == y.Age)
            {
                return 0;
            }
            //Greater 1
            if (x.Age > y.Age)
            {
                return 1;
            }
            //Less than -1
            if (x.Age < y.Age)
            {
                return -1;
            }
            return 0;
        }
    }

    class ClsPerson : IComparable<ClsPerson>
    {
        private int _Age;
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int CompareTo(ClsPerson other)
        {
            //We need to define the custom sort
            //Age is equale than it sort on name
            if (this.Age == other.Age)
            {
                return this.Name.CompareTo(other.Name);

            }
            //Default sort on age
            return this.Age.CompareTo(other.Age);

        }
    }
    class IComparableAndIComparerDemo
    {
        static ClsPerson CreateObject(int Age, string Name)
        {
            ClsPerson obj = new ClsPerson();
            obj.Age = Age;
            obj.Name = Name;
            return obj;

        }
        static void Main(string[] args)
        {
            #region NORMAL LIST
            //List<string> People = new List<string>();
            //People.Add("MOULI CHANDRA");
            //People.Add("Mani Deepthi");
            //People.Add("MAHANTESH");
            //People.Add("Sneha");
            //People.Add("Yogesh");
            //People.Add("Dheeraj  V S R SRallabandi");
            //People.Add("Sabarni Dasgupta");
            //People.Add("VIKAS KUMARTHAKUR");
            //People.Add("BHELAWE GHOSHITCHANDRAMANI");
            //People.Add("Daware NikitaSudhakar");
            //People.Add("DIVYA EDIGA");
            //People.Add("RAGHU RAMIREDDY SURAM");
            //People.Add("Sai Revanth Sivaraju ");
            //People.Add("VenkateswarluYendeti");
            //People.Add("Anand Sharma");
            //People.Add("Sushmika PR");
            //People.Add("Sanchayeta Ghosh");
            //People.Add("RH");
            //People.Add("Arijit Dutta");
            //People.Add("RISHAV VERMA");
            //People.Add("Nishan KumarGhosh");
            //People.Add("Anima Shaw");
            //People.Add("Anoushka Roy");
            //People.Add("Tiasa Mukherjee");
            //People.Add("kishalay bhowmick");
            //People.Add("GOURAV KESHARI");
            //People.Add("Vidhi Singrodia");
            //People.Add("Jatin Krupchandani");
            //People.Add("Saadia Hossain");
            //People.Add("teja jagannadha sri harnath malla");
            //People.Sort();


            //foreach (string name in People)
            //{
            //    Console.WriteLine(name);

            //}


            //List<ClsPerson> PeopleList1 = new List<ClsPerson>()
            //{

            //    new ClsPerson(){Age=21,Name="Ghoshit"},
            //    new ClsPerson(){Age=21,Name="Ghoshit"}


            //};
            #endregion

            Console.WriteLine("\n PEOPLE2 LIST :\n ");

            List<ClsPerson> People2 = new List<ClsPerson>();
            People2.Add(CreateObject(21,"MOULI CHANDRA"));
            People2.Add(CreateObject(21,"Mani Deepthi"));
            People2.Add(CreateObject(22,"MAHANTESH"));
            People2.Add(CreateObject(22,"Sneha"));
            People2.Add(CreateObject(23,"Yogesh"));
            People2.Add(CreateObject(23,"Dheeraj  V S R SRallabandi"));
            People2.Add(CreateObject(23,"Sabarni Dasgupta"));
            People2.Add(CreateObject(21,"VIKAS KUMARTHAKUR"));
            People2.Add(CreateObject(21,"BHELAWE GHOSHITCHANDRAMANI"));
            People2.Add(CreateObject(21,"Daware NikitaSudhakar"));
            People2.Add(CreateObject(22,"DIVYA EDIGA"));
            People2.Add(CreateObject(22,"RAGHU RAMIREDDY SURAM"));
            People2.Add(CreateObject(22,"Sai Revanth Sivaraju "));
            People2.Add(CreateObject(23,"VenkateswarluYendeti"));
            People2.Add(CreateObject(23,"Anand Sharma"));
            People2.Add(CreateObject(23,"Sushmika PR"));
            People2.Add(CreateObject(23,"Sanchayeta Ghosh"));
            People2.Add(CreateObject(23,"RH"));
            People2.Add(CreateObject(21,"Arijit Dutta"));
            People2.Add(CreateObject(21,"RISHAV VERMA"));
            People2.Add(CreateObject(22,"Nishan KumarGhosh"));
            People2.Add(CreateObject(22,"Anima Shaw"));
            People2.Add(CreateObject(22,"Anoushka Roy"));
            People2.Add(CreateObject(21,"Tiasa Mukherjee"));
            People2.Add(CreateObject(21,"kishalay bhowmick"));
            People2.Add(CreateObject(22,"GOURAV KESHARI"));
            People2.Add(CreateObject(23,"Vidhi Singrodia"));
            People2.Add(CreateObject(22,"Jatin Krupchandani"));
            People2.Add(CreateObject(21,"Saadia Hossain"));
            People2.Add(CreateObject(21, "teja jagannadha sri harnath malla"));
            
            People2.Sort(new CompareByAge());//new CompareByAge()
            foreach (ClsPerson obj in People2)
            {
                Console.WriteLine(obj.Name + " " + obj.Age);

            }





        }
    }
}
