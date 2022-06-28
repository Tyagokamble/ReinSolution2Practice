using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.CollectionDemo
{
    class Customer
    {
        int cid;
        string cname;
        ArrayList itemlist;

        public Customer(int cid, string cname, ArrayList itemlist)
        {
            this.cid = cid;
            this.cname = cname;
            this.itemlist = itemlist;
        }
    }

    class TestCustomer
    {
        static void Main(string[] args)
        {
            ArrayList olist = new ArrayList();
            do
            {

                Console.WriteLine("Enter the customer id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the customer name");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter how many items do you want");
                int c = int.Parse(Console.ReadLine());

                ArrayList itemlist = new ArrayList();

                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine($"{cname} enter the item name");
                    string h = Console.ReadLine();
                    itemlist.Add(h);
                }

                Customer cs = new Customer(1, "vaibhav", itemlist);
                olist.Add(cs);

                Console.WriteLine("Do you want to place another order yes/no");
                string choice = Console.ReadLine();

                if (choice == "no")
                    break;
            } while (true);
        }
    }
}
