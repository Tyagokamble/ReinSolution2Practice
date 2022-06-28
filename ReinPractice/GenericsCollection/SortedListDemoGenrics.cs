using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.HashTableDemo
{
    class SortedListDemoGenrics
    {
    
   
        static void Main(string[] args)
        {
            //sorted list stores the data in the form of  key-value pairs.
            //key should be unique.
            //Data automatically internally is stored according to sorted order of keys.

            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Rohit", 85);
            ss.Add("Aadarsh", 85);
            ss.Add("Jayraj", 85);
            ss.Add("Abhishek", 85);

            foreach (KeyValuePair<string, int> k in ss)
            {
                Console.WriteLine(k.Key + "==>" + k.Value);// it will basically print the values in the sorted form like aadarsh,abhishek
                                                           // ,jayraj and rohit.
            }
        }
    }
}
