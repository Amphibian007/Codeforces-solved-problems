using System;
/// <summary>
/// Educational Codeforces Round 83 (Rated for Div. 2), problem: (A) Two Regular Polygons, Accepted
/// </summary>

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = input[0];
                int m = input[1];
                if (n % m == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
        
    }
}
