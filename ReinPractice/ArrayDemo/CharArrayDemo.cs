using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'A', 'T', 'U', 'F' };    

            foreach(char c in ch)
            {
                Console.Write( c);
            }
            Console.WriteLine("/////////////");
          
            for(int i = 0; i < ch.Length; i++)      //print using for loop assignment
            {
                Console.WriteLine(ch[i]);
            }
                
        }
    }
}
