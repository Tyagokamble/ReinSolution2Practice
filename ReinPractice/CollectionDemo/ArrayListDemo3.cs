using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ReinPractice.CollectionDemo
{
    class ArrayListDemo3
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("raj");
            al.Add("Suraj");
            al.Add("Aniket");
            al.Add("rohit");
            al.Sort();


            string reverse = " ";
            for (int i = al.Count - 1; i >= 0; i--)
            {
                reverse = reverse + al[i];
            }
            Console.WriteLine(reverse);


        }
    }
    class Player
    {
        int playerid;
        string name, country, team;
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("MSDhoni");
            al.Add("India");
            al.Add("Chennai Super Kings");

            foreach (var i in al)
            {
                Console.Write(" " + i);
            }

        }
    }

}

