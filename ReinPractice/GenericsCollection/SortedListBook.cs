using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{

    class Book : IComparable<Book>
    {
        int bid;
        string bname;
        int bprice;
        public Book(int bid, string bname, int bprice)
        {
            this.Bid = bid;
            this.Bname = bname;
            this.Bprice = bprice;

        }

        public int Bid { get => bid; set => bid = value; }
        public string Bname { get => bname; set => bname = value; }
        public int Bprice { get => bprice; set => bprice = value; }

        public int CompareTo(Book? other)
        {
            if (this.bprice == other.bprice)
                return this.bname.CompareTo(other.bname);
            else
                return this.bprice.CompareTo(other.bprice);
        }
        public override string ToString()
        {
            return $"Id : {bid} Name:{bname} Price:{bprice}";
        }
    }

    class SortedListBook
    {
        static void Main(string[] args)
        {
            SortedList<Book, string> ss = new SortedList<Book, string>();
            ss.Add(new Book(1, "Harry Potter", 200), "J.K.RowLing");
            ss.Add(new Book(2, "Insomnia", 250), "Rachna Bisht");
            ss.Add(new Book(3, "Throne Of Glass", 600), "Sarah J Maas");
            ss.Add(new Book(1, "Assassin's Blade", 200), "Sarah J Maas");
            


            foreach (KeyValuePair<Book, string> k in ss)
            {
                Console.WriteLine(k.Key + "==>" + k.Value);
            }
        }

    }
}
