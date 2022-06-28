using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.Test1Assignment
{
    class Test2loop
    {
        static void Main(string[] args)
        {
                int b = 0;
                do
                {
                    int a = 2;
                    b++;
                    Console.WriteLine(a++);
                }
                while (b != 3);
            }

        }
    }

