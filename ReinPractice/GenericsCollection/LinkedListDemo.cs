using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            //Linked list is used if you want to insert in between and delete in between is faster.
            //link = searching or retrival of data is faster.

            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(45);
            ll.AddLast(67);
            ll.AddFirst(20);
            

            //Console.WriteLine(ll.Remove(45));

            foreach (int d in ll)
            {
                Console.WriteLine(d);
            }

            //20,90,45,67
            //Node = It is a variable which can store the data and address of the next element in it.

            LinkedListNode<int> n1 = ll.Find(90);// n1is adress of for replacing element
            ll.AddAfter(n1, new LinkedListNode<int>(900));//or 900);

            ll.Remove(45);//it will find the address of the data and then will delete the data implicitly.
        }
    }
}
