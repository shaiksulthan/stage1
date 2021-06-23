using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay5
{

    class Color
    {
        public string[] arrcolor;
        public Color()
        {
            arrcolor = new string[5];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arrcolor.Length)
                {
                    return arrcolor[index];
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < arrcolor.Length)
                {
                    arrcolor[index] = value;
                }
                else
                    throw new IndexOutOfRangeException();

            }


        }
        public string getColor(int index)
        {
            return arrcolor[index];
        }
        public void setColor(int index, string color)
        {
            arrcolor[index] = color;
        }

        public void ShowColor()
        {
            for (int i = 0; i < arrcolor.Length; i++)
            {
                Console.WriteLine(arrcolor[i]);
            }

        }

    }
}
