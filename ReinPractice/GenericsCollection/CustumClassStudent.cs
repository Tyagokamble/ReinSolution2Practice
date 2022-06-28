using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{
    class CustumClassStudent
    {
        static void Main(string[] args)
        {
            HashSet<stud> hs = new HashSet<stud>();
            hs.Add(new stud(1, "Aadarsh", 90));
            hs.Add(new stud(1, "Aadarsh", 90));


          /*  foreach (KeyValuePair<stud> i in  hs)
            {
                Console.WriteLine(i.key + "==>" + i.Value);
            }*/

        }
    }

}


