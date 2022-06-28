using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ReinPractice.CollectionDemo
{
    class ArrayListDemo1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add("mon");
            al.Add("sun");
            al.Add("sat");
            al.Add("tues");
            al.Add("mon");
            al.Add("sun");
            al.Add("sat");
            al.Add("mon");
            al.Add("sun");
            al.Add("sat");

            al.Remove("mon");
            al.Remove("sun");
            al.Remove("sat");
            al.Remove("mon");
            al.Remove("sun");
            al.Remove("sun");
            al.Remove("sat");
            al.Remove("mon");
            al.Remove("sat");

            foreach (var a in al)
            {
                Console.WriteLine(a);
            }
        }
    }
}
