using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class MyEmployee
    {
        public void show()                            // here we created method and used object of main class.
        {
            EncapsulationDemo1Employee e = new EncapsulationDemo1Employee();
           e.Id = 300;
           e.Name = "nikhil";
            Console.WriteLine(e.Id);
            Console.WriteLine(e.Name);

        }
    }

    class EncapsulationDemo1Employee
    {
        private int id;                                   //private members
        private string name;

        public int Id
        {
            get { return id; }                          // getter and setter method to access private members
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name =value;}
        }

        static void Main(string[] args)
        {
            EncapsulationDemo1Employee e = new EncapsulationDemo1Employee();
            MyEmployee me = new MyEmployee();                                   //anather class object created
            e.Id = 1;
            e.Name = "rahul";
            Console.WriteLine(e.Id);
            Console.WriteLine(e.Name);
            me.show();
       

        }
    }
}
