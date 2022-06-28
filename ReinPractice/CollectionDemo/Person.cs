using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ReinPractice.CollectionDemo
{
    class Person
    {
        string name;
        ArrayList hobbies;

        public Person(string name, ArrayList hobbies)
        {
            this.name = name;
            this.hobbies = hobbies;
        }


        class TestPerson
        {
            static void Main(string[] args)
            {
                ArrayList plist = new ArrayList();

                do
                {
                    Console.WriteLine("Enter a name");
                    string name = Console.ReadLine();
                    Console.WriteLine("ENter the number of hobbies u have");
                    int c = int.Parse(Console.ReadLine());
                    ArrayList hobbieList = new ArrayList();
                    for (int i = 1; i <= c; i++)
                    {
                        Console.WriteLine($"{name} enter your hobby");
                        string h = Console.ReadLine();
                        hobbieList.Add(h);
                    }
                    Person p = new Person(name, hobbieList);
                    plist.Add(p);

                    Console.WriteLine("Do you want to add one more person object yes/no");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "no")
                    {
                        break;
                    }

                } while (true);
            }
        }
    }
}
