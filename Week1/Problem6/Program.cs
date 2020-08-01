using System;
/// <summary>
/// 1354A - Alarm Clock
/// </summary>

namespace Problem6
{
    class Program
    {  
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                decimal[] input = Array.ConvertAll(Console.ReadLine().Split(' '), decimal.Parse);
                decimal a = input[0];
                decimal b = input[1];
                decimal c = input[2];
                decimal d = input[3];
                if (b >= a)
                    Console.WriteLine(b);
                else if (c - d <= 0)
                    Console.WriteLine("-1");
                else
                {
                    decimal sleepLeft = a - b;
                    decimal toSleep = c - d;
                    decimal round = (decimal)Math.Ceiling(sleepLeft / toSleep);
                    decimal time = b + round * c;
                    Console.WriteLine(time);
                }
            }
        }
    }
}
