using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int a = input[0];
                int b = input[2];
                if (a != b)
                    Console.WriteLine(a + " " + b);
                else
                    Console.WriteLine(a + " " + (b + 1));
            }
        }
    }
}