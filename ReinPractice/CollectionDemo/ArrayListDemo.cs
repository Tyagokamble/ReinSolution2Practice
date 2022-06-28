using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ReinPractice.CollectionDemo
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(43);
            al.Add(896595);
            al.Add(4);
            Console.WriteLine( "capacity:"+al.Capacity);
            Console.WriteLine("count:"+al.Count);
            Console.WriteLine(al.IsFixedSize);

            foreach(var a in al)
            {
                Console.WriteLine(a);
            }
         
        }
    }
}
