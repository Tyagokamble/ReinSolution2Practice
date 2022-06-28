using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.Test1Assignment
{
    class Test3Loop
    {
        static void Main(string[] args)
        {
            int i = 1,k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k" +k +"i" +i);

        }
    }
}
