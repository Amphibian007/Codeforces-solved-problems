using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            Console.WriteLine(sum);

        }
    }
}
