using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class MergingOfUniqueElements
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 7, 4, 3, 6, 3, 7, 2, 1 };
            int[] b = new int[] { 10, 11, 22, 33, 10, 22, 20, 30, 20 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool Isvisited = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        Isvisited = true;
                        break;
                    }

                }
                if (Isvisited == false)
                {

                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        c[k] = a[i];
                        k++;
                    }

                }


            }

            for (int i = 0; i < b.Length; i++)
            {
                int count = 1;
                bool IsVisited = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (b[i] == b[j])
                    {
                        IsVisited = true;
                        break;
                    }
                }
                if (IsVisited == false)
                {
                    for (int m = i + 1; m < b.Length; m++)
                    {
                        if (b[i] == b[m])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        c[k] = b[i];
                        k++;
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(c[i]);
            }
        }        
    }
}
            
            
            
            
            
            
            
            
            
            
            
           
        
    

