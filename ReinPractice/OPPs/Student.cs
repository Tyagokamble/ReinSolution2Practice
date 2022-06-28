using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class Student
    {
        int id;
        string name;
        int physics,chemistry,maths;
        float percentage;

        public void acceptDetails()
        {
            id = 1;
            name = "vishal";
            physics = 88;
            chemistry = 76;
            maths = 79;
            
        }
        public void percent()
        {
             percentage = (physics + chemistry + maths/3) * 100;
        }
        public void display()
        {
            Console.WriteLine(id +" "+name+" "+physics +" "+ chemistry+ " "+maths);
            Console.WriteLine(percentage);
        }
        static void Main(string[] args)
        {
            Student st = new Student();
            st.acceptDetails();
            st.percent();
            st.display();

        }
    }
}
