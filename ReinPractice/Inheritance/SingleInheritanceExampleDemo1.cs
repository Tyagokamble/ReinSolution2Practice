using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class SingleInheritanceExampleDemo1
    {
        class Vehicle
        {
            public int speed = 60;
        }

        class Car : Vehicle
        {
            public void run()
            {
                Console.WriteLine("car runs at "+speed);
            }
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.run();

        }
    }
}
