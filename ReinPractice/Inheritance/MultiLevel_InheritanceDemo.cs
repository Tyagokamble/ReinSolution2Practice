using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class MultiLevel_InheritanceDemo
    {
        class GrandFather
        {
             int age = 70;
             string name = "Ritesh";

         public void show()
           {
                Console.WriteLine(age+""+name);
           }

        }
        class Father:GrandFather
        {
             int age1 = 50;
             string name1 = "chetan";
        public void show1()
            {
                Console.WriteLine(age1 + " "+name1);
            }
        }
        class Son:Father
        {
             int age2 = 28;
             string name2 = "rahul";
         public void show2()
            {
                Console.WriteLine(age2+" "+name2);
            }


        }
        static void Main(string[] args)
        {
            Son s = new Son();
            s.show();
            s.show1();
            s.show2();
        }
    }
}
