using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class ReverseStringbyrecursion
    {
        static void reverse(string str)
        {
            if(str !="")
            {
                Console.WriteLine(str[str.Length-1]);       //d, a,
                reverse(str.Substring(0, str.Length - 1));
            }
        }
        static void Main(string[] args)
        {
            reverse("prasad");
            
        }
    }
}
