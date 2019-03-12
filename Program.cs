using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jose
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0, p = 2, count = 0;
            Console.WriteLine("Number of people");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            for (i = 1; i <= n; i++)
            {
                a[i] = 1;
            }
            i = 1;
            for(j=1;j<n;)
            {
                if(i>n)
                {
                    i = 1;
                }
                if (a[i]!= 0)
                {
                    count++;
                    if (count == p)
                    {
                        a[i] = 0;
                        j++;
                        count = 0;
                    }
                }
                i++;
            }
            int v = Array.IndexOf(a,1);
            Console.WriteLine(v + " is the last person.");

        }
    }
}