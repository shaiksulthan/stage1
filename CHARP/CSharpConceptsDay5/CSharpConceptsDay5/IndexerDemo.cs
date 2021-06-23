using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay5
{
    class IndexerDemo
    {
        static void Main(string[] args)
        {
            Color colors = new Color();
            colors.setColor(0, "Magenta");
            colors.setColor(1, "Black");
            colors.setColor(2, "Orange");
            colors.setColor(3, "Tomato");
            colors.setColor(4, "PowderBlue");
            colors.ShowColor();

            Color[] acolor = new Color[3];
            acolor[0] = new Color();
            acolor[0][0] = "Brown";
            acolor[0][1] = "Blue";
            acolor[0][2] = "Black";
            acolor[0][3] = "Burgundy";
            acolor[0][4] = "Blue Deep";


            for (int i = 0; i < acolor[0].arrcolor.Length; i++)
            {
                Console.WriteLine(acolor[0][i]);
            }

            acolor[1] = new Color();
            acolor[1][0] = "Black";
            acolor[1][1] = "Peach";
            acolor[1][2] = "Green";
            acolor[1][3] = "Aqua Blue";
            acolor[1][4] = "Teal";


            for (int i = 0; i < acolor[1].arrcolor.Length; i++)
            {
                Console.WriteLine(acolor[1][i]);
            }



        }
    }
}
