using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class FriendAgeComparison
    {
        static void Main(string[] args)
        {
            int myage, friendsage;
            Console.WriteLine("enter my age: ");
            myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter friends Age:");
            friendsage = Convert.ToInt32(Console.ReadLine());
            if (friendsage>myage)
            {
                Console.WriteLine("Print Hii");
            }
            else if (friendsage<myage )
            {
                Console.WriteLine("Print Good Morning");
            }
            else
            {
                Console.WriteLine("how are you?"); 
            }
        }
    }
}
