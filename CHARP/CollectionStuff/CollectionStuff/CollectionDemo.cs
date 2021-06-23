using System;
using System.Collections;//.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStuff
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            //FunArrayList();
             //FunStack();
            //FunQueue();
            FunHastable();

        }

        private static void FunHastable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(10, "TEN");
            hashtable.Add(20, "TWENTY");
            hashtable.Add(30, "THRITY");
            hashtable.Add(40, "FORTY");
            hashtable.Add(50, "FIFTY");
            Console.WriteLine("By using IDictionaryEnumerator:");
            IDictionaryEnumerator iDen = hashtable.GetEnumerator();
            while (iDen.MoveNext())
            {
                Console.WriteLine("Key {0} and Value {1}", iDen.Key, iDen.Value);
            }

            Console.WriteLine("By using foreach loop :");
            foreach (DictionaryEntry ele in hashtable)
            {
                Console.WriteLine("{0} {1}", ele.Key, ele.Value);
            }
            Console.WriteLine("By reading keys :");
            foreach (int k in hashtable.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("by reading values:");
            foreach (string v in hashtable.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Reading the 30 key value : {0}", hashtable[30]);





            SortedList sortedList = new SortedList();
            sortedList.Add(10, "TEN");
            sortedList.Add(20, "TWENTY");
            sortedList.Add(30, "THRITY");
            sortedList.Add(60, "SIXTY");
            sortedList.Add(40, "FORTY");
            sortedList.Add(50, "FIFTY");

            Console.WriteLine("By using foreach loop :");
            foreach (DictionaryEntry ele in sortedList)
            {
                Console.WriteLine("{0} {1}", ele.Key, ele.Value);
            }
        }

        private static void FunQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("TEN");
            queue.Enqueue(10.01f);
            queue.Enqueue(false);
            queue.Enqueue(1234.567m);

            Console.WriteLine("By using foreach loop :");
            foreach (var que in queue)
            {
                Console.WriteLine(que + " " + que.GetType());
            }

            Console.WriteLine("Dequeue : " + queue.Dequeue());
        }

        private static void FunStack()
        {
            Stack stk = new Stack();
            stk.Push(2.0f);
            stk.Push(3.2f);
            stk.Push(0.0f);
            stk.Push(0.4f);
            stk.Push(0.9f);

            Console.WriteLine("By using foreach loop :");
            foreach (float ele in stk)
            {
                Console.WriteLine(ele + " " + ele.GetType());
            }

            Console.WriteLine("Let's pop : " + stk.Pop());
            Console.WriteLine("By using IEnumerator :");
            IEnumerator iEn = stk.GetEnumerator();
            while (iEn.MoveNext())
            {
                Console.WriteLine(iEn.Current);
            }

            //Console.WriteLine("By using for loop :");
            // Not applicable
            //for (int i = 0; i < stk.Count; i++)
            //{
            //    Console.WriteLine(stk[i]);
            //}
        }

        private static void FunArrayList()
        {
            ArrayList aList = new ArrayList();
            aList.Add("One");
            aList.Add("Two");
            aList.Add("Three");
            aList.Add("Four");
            aList.Add("Five");

            Console.WriteLine("By Using forloop :");
            for (int i = 0; i < aList.Count; i++)
            {
                Console.WriteLine(aList[i]);
            }
            Console.WriteLine("By using foreach loop:");
            foreach (string ele in aList)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("By Using IEnumerator:");

            int val = 12345;
            int[] MyIntArray = { 1, 2, 3, 4, 5, 6 };

            IEnumerator iEn = aList.GetEnumerator();
            while (iEn.MoveNext())
            {
                Console.WriteLine(iEn.Current.ToString());
            }

            Console.WriteLine("Re EXECUTE this loop ");
            iEn.Reset();
            ShowElements(iEn);
        }

        private static void ShowElements(IEnumerator iEn)
        {
            while (iEn.MoveNext())
            {
                Console.WriteLine(iEn.Current.ToString());
            }
        }
    }
}
