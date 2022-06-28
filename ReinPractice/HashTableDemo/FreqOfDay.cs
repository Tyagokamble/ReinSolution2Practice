using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.HashTableDemo
{
    class FreqOfDay
    {
        static void Main(string[] args)
        {
              ArrayList al = new ArrayList()
              {
                  "sun","mon","tues","wed","sun"
              };
                Hashtable ht =new Hashtable();

                foreach (dynamic data in al)
                {
                    if (ht.ContainsKey(data))
                    {
                        int value = (int)ht[data];
                        ht[data] = value + 1;
                    }
                    else
                      ht.Add(data, 1);
                }
                foreach(DictionaryEntry d in ht)
                {
                    Console.WriteLine(d.Key+"=>"+d.Value);
                }
            

        }

    }
}
