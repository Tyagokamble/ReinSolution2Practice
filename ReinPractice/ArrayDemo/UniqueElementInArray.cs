using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class UniqueElementInArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 4, 5, 1, 3, 2, 6, 7, 6, 7 };

            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;//this count we have taken inside of the for loop because for each number the counter
                              //should start counting from 1. and the counter will start from 1 coz in array that perticular
                              //number is always going be there
                bool IsVisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        IsVisited = true;
                        break;
                    }
                }
                if (IsVisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    //if (count == 1) unique elements
                    //if (count > 1) duplicate elements
                    //if count is not used then it is for frequency of each number.

                   if(count==1) {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }
            }
        }
       
    }
}
