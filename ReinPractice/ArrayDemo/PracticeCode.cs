using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class PracticeCode
    {
        static void Main(string[] args)
        {
            int n = 25;
            int rem, sum;
            while (n > 9)
            {
                sum = 0;
                while (n != 0)
                {
                    rem = n % 10;
                    sum = sum + (rem * rem);
                    n = n / 10;
                }
                n = sum;
            }
            if (n == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            /*   string s = "1,2,3,4,5,6";
               char[] ch = s.ToCharArray();
               int count = 0;
               int sum = 0;
               for (int i = 0; i < ch.Length; i++)
               {
                   if (ch[i] >= '0' && ch[i] <= '9')
                   {
                       int x = int.Parse(ch[i].ToString());
                       sum = sum + x;
                       count++;
                   }
               }
               Console.WriteLine("The sum is: " + sum + " the count is: " + count);
               int avg = sum / count;
               Console.WriteLine("The avg is: " + avg);*/
            /*    int[] a = { 1, 2, 2, 3, 4 };
                int[] b = { 5, 6, 6, 7, 8 };
                int[] c = new int[a.Length + b.Length];
                int k = 0;
                for (int i = 0; i < a.Length; i++)
               {
                    int count = 1;
                    bool isvisited = false;
                    for (int m = i - 1; m >= 0; m--)
                    {
                        if (a[i] == a[m])
                        {
                            isvisited = true;
                            break;
                        }
                    }
                    if (isvisited ==false)
                    {
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            if (a[j] == a[i])
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
                    bool isvisited = false;
                    for (int m = i - 1; m >= 0; m--)
                    {
                        if (b[i] == b[m])
                        {
                            isvisited =true;
                            break;
                        }
                    }
                    if (isvisited == false)
                    {
                        for (int j = i + 1; j < b.Length; j++)
                        {
                            if (b[j] == b[i])
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
                }*/

            /*  int[] a = { 2, 3, 7, 6, 8 };
              int count = 0;
              int sum = 0;
              for (int i = 0; i < a.Length; i++)
              {
                  for (int j = 2; j < a[i] / 2; j++)
                  {

                      if (a[i] % j == 0)
                      {
                          count++;

                      }
                      Console.WriteLine(count);
                  }
              }*/

            // C# program to check if a number
            // is a Happy number or not.


        }
    }
}         
       
           
        
    






