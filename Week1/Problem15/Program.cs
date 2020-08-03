using System;
/// <summary>
/// A - Dawid and Bags of Candies
/// </summary>

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(input1);
            int a1 = input1[0];
            int a2 = input1[1];
            int a3 = input1[2];
            int a4 = input1[3];

            if(a4==a1+a2+a3|| a4+a1==a2+a3)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

         


        }
    }
}
