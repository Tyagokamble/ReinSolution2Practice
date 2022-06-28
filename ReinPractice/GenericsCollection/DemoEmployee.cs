using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{
    class Employee : IComparable<Employee>
    {
        int eid;
        string enm;
        int esalary;

        public Employee(int eid, string enm, int esalary)
        {
            this.Eid = eid;
            this.Enm = enm;
            this.Esalary = esalary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Enm { get => enm; set => enm = value; }
        public int Esalary { get => esalary; set => esalary = value; }

        public int CompareTo(Employee? other)
        {
            if (this.esalary == other.esalary)
                return this.enm.CompareTo(other.enm);
            else
                return this.esalary.CompareTo(other.esalary);
        }
        public override string ToString()
        {
            return $"Id: {eid} Name: {enm} Salary: {esalary}";
        }
    }


      class SortBySalary : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            Console.WriteLine("in compare");
            return e2.Esalary.CompareTo(e1.Esalary);
        }
    }

    class DemoEmployee
    {
            static void Main(string[] args)
            {
                SortedList<Employee, string> es = new SortedList<Employee, string>(new SortBySalary() );// by calling sotbys

                es.Add(new Employee(1, "Ram", 20000), "Develper");
                es.Add(new Employee(2, "shyam", 23000), "Tester");
                es.Add(new Employee(3, "Akash", 22000), "HR");
                es.Add(new Employee(4, "Yogesh", 27000), "Develper");
                es.Add(new Employee(5, "Akshay", 21000), "Accontant");


                foreach (KeyValuePair<Employee, string> e1 in es)
                    Console.WriteLine(e1.Key + "," + e1.Value);
            }
    }
}
