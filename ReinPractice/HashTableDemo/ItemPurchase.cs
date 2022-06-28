using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.HashTableDemo
{
    class ItemPurchase
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
               {
                   "Laptop",
                   "Mobile",
                   "HeadPhone",
                   "Mobile",
                   "Laptop",
                   "tablet"
              };


            foreach (dynamic data in al)
            {
                Console.WriteLine(data);
            }
            Hashtable ht = new Hashtable();

            foreach (dynamic data in al)
            {
                if (ht.ContainsKey(data))
                {
                    int a = (int)ht[data];
                    ht[data] = a + 1;
                }
                else
                    ht.Add(data, 1);
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "-->" + d.Value);
            }

        }
    }
}
