using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.GenericsCollection
{
    class stud:IComparable<stud>
    {
        int sid;
        string name;
        double percent;

        public stud(int sid, string name, double percent)
        {
            this.Sid = sid;
            this.Name = name;
            this.Percent = percent;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public double Percent { get => percent; set => percent = value; }

        public int CompareTo(stud other)
        {
            if (this.Percent > other.percent)
            {
                return 1;
            }
            else if (this.percent < other.percent)
            {
                return -1;
            }
            else
                return 0;
        }

        public override bool Equals(object obj)
        {
            return obj is stud stud &&
                   Sid == stud.Sid &&
                   Name == stud.Name &&
                   Percent == stud.Percent;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Sid, Name, Percent);
        }
    }
}

