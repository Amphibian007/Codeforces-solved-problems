using System;
/// <summary>
/// 	835A - Key races
/// </summary>

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int s = input[0];
            int c1 = input[1];
            int c2 = input[2];
            int p1 = input[3];
            int p2 = input[4];
            int friend1 = s * c1 + 2 * p1;
            int friend2 = s * c2 + 2 * p2;

            if(friend1<friend2)
                Console.WriteLine("First");
            else if(friend1>friend2)
                Console.WriteLine("Second");
            else
                Console.WriteLine("Friendship");
        }
    }
}
