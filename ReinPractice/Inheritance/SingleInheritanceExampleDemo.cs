using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class Animal
    {
        public int legs = 4;                 // why created public member
    } 
    
    class Cat : Animal
    {
        public void show()
        {
            Console.WriteLine(legs);
        }
    }
    class SingleInheritanceExampleDemo
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.show();

        }
    }
}
