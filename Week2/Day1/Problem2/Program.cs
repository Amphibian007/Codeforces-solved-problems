using System;
/// <summary>
/// Codeforces Round #131 (Div. 2), problem: (A) System of Equations
/// </summary>

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int a, b;
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = input[0];
            int m = input[1];
            
            for( a = 0; a <= 1000; a++)
            {
                for (b = 0; b <= 1000; b++)
                {
                    if (a * a + b == n && a + b * b == m)
                        count++;
                }  
            }
            Console.WriteLine(count);
        }
    }
}
