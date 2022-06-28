using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.HashTableDemo
{
    class QuequeDemo
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("om");
            q.Enqueue("raj");
            q.Enqueue("shree");
            Console.WriteLine(q);

            int d = (int)q.Dequeue();
            Console.WriteLine(q.Peek());
            Console.WriteLine("remove" + d);

            foreach (var i in q)
            {
                Console.WriteLine(i);
            }

        }
    }
    class Potential1
    {
        static int Pot(string word)
        {
            int p = 0;
            for (int i = 0; i < word.Length; i++)
            {
                p = p + word[i];
            }
            return p;
        }
        public static void Main(string[] args)
        {
            //write sentense acorridng to tis potential
            // the sky is the limit.
            string s = "the sky is the limit";
            s.ToLower();
            string []arr = s.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Pot(arr[i]) > Pot(arr[j]))
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                foreach(var d in arr)
                {
                    Console.WriteLine(d);
                }
            }

        }
    }
}
