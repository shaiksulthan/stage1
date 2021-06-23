using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay2
{
    class StringBuilderClassDemo
    {
        static void Main(string[] args)
        {
            //Instancetiate stringbuilder to except 50 characters 
            StringBuilder sb = new StringBuilder("ABC", 50);
            //APPEND THREE CHARACTERS D,E,F TO THE END OF SB
            sb.Append(new char[] { 'D', 'E', 'F' });

            //APPEND FORMATED STRING TO THE SB
            sb.AppendFormat("GHI{0}{1}", 'J', 'K');
            Console.WriteLine("{0} Characters {1}", sb, sb.Length);
            sb.Insert(0, "ALPHABETS : ");
            sb.Replace('A', 'a');
            Console.WriteLine(sb);



        }
    }
}
