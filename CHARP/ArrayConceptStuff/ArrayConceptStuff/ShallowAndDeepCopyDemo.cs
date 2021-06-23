using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConceptStuff
{
    class Foo
    {
        int[] data;
        public Foo(int[] Values)
        {
            //Shallow copy reference
            //data = Values;

            //Deep copy 
            //Deep copy means actually creating new array and copying over
            //the values

            data = new int[Values.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Values[i];
            }
        }
        public void ShowData()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

        }


    }
    class ShallowAndDeepCopyDemo
    {
        static void Main(string[] args)
        {
            int[] vals = { -5, 12, 3 };
            Foo obj = new Foo(vals);

            //obj.ShowData();
            //Shallow copy
            vals[2] = 13;
            obj.ShowData();


        }
    }
}
