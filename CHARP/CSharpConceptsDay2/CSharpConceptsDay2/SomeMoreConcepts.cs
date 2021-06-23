using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class SomeMoreConcepts
    {
        static void Main(string[] args)
        {
            #region TERNARY OPERATOR DEMO
            int a = 35, b = 78;
            string result = (a > b) ? "A IS GREATER " : "B IS GREATER";
            Console.WriteLine(result);
            #endregion
            #region ASCII CODE CHARACTER 
            for (int i = 0; i <=255; i++)
            {
                Console.WriteLine("CODE : {0} and CHARACTER : {1}",i,(char)i);
            }
            #endregion 
        }
    }
}
