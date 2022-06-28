using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.HashTableDemo
{
    class HotelMenu
    {
        static void Main(string[] args)
        {
            Hashtable snacks = new Hashtable();
            snacks.Add("vadapaav", 40);
            snacks.Add("sandwich", 150);
            snacks.Add("burger", 200);
            snacks.Add("samosa", 60);

            Hashtable beverages = new Hashtable();
            beverages.Add("coldDrink", 80);
            beverages.Add("milk", 60);
            beverages.Add("Cofee", 90);
            beverages.Add("soda", 75);

            Hashtable ht = new Hashtable();
            ht.Add("snacks", snacks);
            
            ht.Add("beverages", beverages);

            foreach(DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key);
                Hashtable c = (Hashtable)i.Value;
                
                foreach (DictionaryEntry v in c)
                {
                    Console.WriteLine(v.Key+"==>"+v.Value);
                }
                Console.WriteLine("//////////////////////////////////////");
            }

            Hashtable Maincourse = new Hashtable();
            do
            {
                Console.WriteLine("enter item u want to order:");
                string item = Console.ReadLine();
                Console.WriteLine("enter qty of item :");
                int qty = int.Parse(Console.ReadLine());
                Maincourse.Add(item, qty);
                Console.WriteLine("do u want order one more item sy y/n");
                string choice = Console.ReadLine().ToLower();
                if(choice =="n")
                {
                    
                    break;
                }

            } while (true);

        }
    }
}
