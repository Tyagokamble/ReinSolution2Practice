using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class ConsrtucterChaining
    {
       
            int x = 10;


            public ConsrtucterChaining() : this(78)
            {
                Console.WriteLine("HI i am defualt");
            }

            public ConsrtucterChaining(int x)
            {
                Console.WriteLine("Hi x----" + x);
            }

            void read(int x)
            {
                this.x = x;
                this.show();
            }
            void show()
            {
                Console.WriteLine(x);
            }


            static void Main(string[] args)
            {
            ConsrtucterChaining d = new ConsrtucterChaining();
            ConsrtucterChaining d1 = new ConsrtucterChaining();
                d.read(500);
                d1.read(100);
                d.show();
            }
        }
}
