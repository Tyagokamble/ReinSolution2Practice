using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{
    class ListAndDictionaryGenerics
    {
        static void Main(string[] args)
        {
            List<int> al = new List<int>();
            al.Add(23);
            al.Add(40);
            
            Console.WriteLine(al[0]);

            List<stud> al2 = new List<stud>();
            Dictionary<int, string> d1 = new Dictionary<int ,string>();
            d1.Add(23, "raj");
            d1.Add(40, "rohit");
         
            Console.WriteLine(d1.ContainsKey(23));        // true
            Console.WriteLine(d1.ContainsValue("rohit")); //true
            d1[23] = "ketaki";                            //replacement
            d1.Remove(23);
         /*   foreach(<int ,string>k in d1)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }*/

            foreach(int a in d1.Keys)
            {
                Console.WriteLine( a+ d1[a]);

            }




        }
    }
}
