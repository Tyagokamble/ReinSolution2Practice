using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ReinPractice.CollectionDemo
{
    class Order
    {
        int orderid;
        int custid;
        string city;
        ArrayList items;

        public Order(int orderid, int custid, string city, ArrayList items)
        {
            this.Orderid = orderid;
            this.Custid = custid;
            this.City = city;
            this.Items = items;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public int Custid { get => custid; set => custid = value; }
        public string City { get => city; set => city = value; }
        public ArrayList Items { get => items; set => items = value; }
    }

    class TestOrder
    {
        static void Main(string[] args)
        {
            ArrayList OrderList = new ArrayList();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("enter orderid,custid,city");
                int orderid = int.Parse(Console.ReadLine());
                int custid = int.Parse(Console.ReadLine());
                string city = Console.ReadLine();
                Console.WriteLine("enter how many items u want to order");
                int c = int.Parse(Console.ReadLine());

                ArrayList itemlist = new ArrayList();

                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Add j items in your order");
                    string item = Console.ReadLine();
                    itemlist.Add(item);
                }
                Order or = new Order(orderid, custid, city, itemlist);
                {
                    OrderList.Add(or);
                }


            }

        }
    }
}
