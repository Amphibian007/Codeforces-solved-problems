using System;
/// <summary>
/// 1003A - Polycarp's Pockets
/// </summary>
namespace D2Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int highest = 0;
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int i = 0; i < n; i++)
            {
                int count = 0;
                for(int j=0;j<n;j++)
                {
                    if (input[i] == input[j])
                        count++;
                }
                if (count >= highest)
                    highest = count;
            }
            Console.WriteLine(highest);
        }
    }
}
