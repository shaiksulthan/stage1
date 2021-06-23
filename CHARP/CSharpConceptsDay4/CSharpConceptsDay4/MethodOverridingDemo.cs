using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsDay4
{
   public class ClsStudent
    {
        public ClsStudent()
        {
            Console.WriteLine("I am student class");
        }
        public  virtual void Show()
        {
            Console.WriteLine("Hello ... Student:");

        }

    }

   public class ClsTeacher : ClsStudent
    {
        public ClsTeacher()
        {
            Console.WriteLine("I am treacher class");
           
        }
        public override void Show()
        {
            Console.WriteLine("Hello ... Teacher:");
        }

    }

  public  class ClsHOD : ClsTeacher
    {
        public ClsHOD()
        {
            Console.WriteLine("I am HOD class");

        }
        public override void Show()
        {
            Console.WriteLine("Hello ... HOD:");
        }


    }

    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            //ClsStudent clsStudent = new ClsStudent();
            //clsStudent.Show();
            //ClsTeacher clsTeacher = new ClsTeacher();
            //clsTeacher.Show();
            //ClsHOD clsHOD = new ClsHOD();
            //clsHOD.Show();


            //Console.WriteLine();
            ////clsStudent = clsHOD;
            ////clsStudent.Show();

            ////clsHOD = (ClsHOD)clsStudent;

            //clsHOD.Show();

            ClsStudent objStud = new ClsStudent();
            ClsHOD objHOD = new ClsHOD();

            //objStud = objHOD;
            //objStud.Show();
            //objHOD =(ClsHOD) objStud;





        }
    }
}
