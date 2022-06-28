using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class EncapsualtionDemoStudent
    {
        int id ;
        private string name;
        private double percentage;

        public int Id                            // properties of private members
        {
            get { return id; }
            set { this.id =value; }
        }
        public string Name                      // created property name to get and set method
        {
            get { return name; }
            set { this.name = value; }
        }

        public double Percentage
        {
            get { return percentage; }
            set { this.percentage = value; }
        }
        static void Main(string[] args)
        {
            EncapsualtionDemoStudent e = new EncapsualtionDemoStudent();
            e.Id = 1;
            e.Name="vaibhav";
            e.Percentage=84;
            Console.WriteLine(e.Id);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Percentage);
        }
    }
}
