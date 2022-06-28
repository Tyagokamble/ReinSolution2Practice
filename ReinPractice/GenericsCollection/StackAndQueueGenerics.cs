using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.GenericsCollection
{
    class StackAndQueueGenerics
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("raj");
            st.Push("viraj");
            st.Push("rohit");
            

            st.Pop();
            Console.WriteLine(st.Peek());
            foreach (string i in st)
            {
                Console.WriteLine(i);
            }

            Queue<double> st1 = new Queue<double>();
            st1.Enqueue(43);
            st1.Enqueue(23);
            st1.Dequeue();
            foreach(double a in st1)
            {
                Console.WriteLine(a);
            }
        }
    }
}
