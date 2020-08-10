using System;
/// <summary>
/// Codeforces Round #509 (Div. 2), problem: (A) Heist
/// </summary>

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(input);
            int low = input[0];
            int high = input[input.Length - 1];
            Console.WriteLine((high-low+1)-n);
        }
    }
}
