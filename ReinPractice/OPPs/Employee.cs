using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class Employee
    {
        int id;
        string name;
        float salary;

        public void acceptDetails()
        {
            id = 1;
            name = "Rahul";
            salary = 20000;
        }

        public void display()
        {
            Console.WriteLine(id+" "+name+" "+ salary);
        }
        static void Main(string[] args)
        {
            Employee E = new Employee();
            E.acceptDetails();
            E.display();
        
        }
           
    }
}
