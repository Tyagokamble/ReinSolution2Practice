using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{
    public class Sort : IComparable<Sort>
    {
        int Release_year;
        string Movie_name;
        string Director_name;

        public Sort(int release_year, string movie_name, string director_name)
        {
            Release_year1 = release_year;
            Movie_name1 = movie_name;
            Director_name1 = director_name;
        }

        public int Release_year1 { get => Release_year; set => Release_year = value; }
        public string Movie_name1 { get => Movie_name; set => Movie_name = value; }
        public string Director_name1 { get => Director_name; set => Director_name = value; }

        public int CompareTo(Sort? other)
        {
            if (this.Release_year == other.Release_year)
                return this.Director_name.CompareTo(other.Director_name);
            else
                return this.Release_year.CompareTo(other.Release_year);
        }

        public override string ToString()
        {
            return $"Year :{Release_year} ,Movie name : { Movie_name} ,Director name : {Director_name}";
        }
    }

    public class MovieList
    {

        public static void Main(string[] args)
        {
            SortedList<Sort, int> sl = new SortedList<Sort, int>();
            sl.Add(new Sort(2008, "The Dark Knight", "Christopher Nolan"), 300000);
            sl.Add(new Sort(2000, "Padmavati", "Sanjay lila Bhansali"), 200000);
            sl.Add(new Sort(2000, "Simmba", "Rohit Shetty"), 600000);


            foreach (KeyValuePair<Sort, int> k in sl)
            {
                Console.WriteLine(k.Key + "==>" + k.Value);
            }
        }
    }
}
