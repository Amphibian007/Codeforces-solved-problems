using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Codeforces Round #279 (Div. 2), problem: (A) Team Olympiad
/// </summary>

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input1 = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            List<int> One = new List<int>();
            List<int> Two = new List<int>();
            List<int> Three = new List<int>();

            for(int i = 0; i < n; i++)
            {
                if (input1[i] == 1)
                    One.Add(i + 1);
                else if (input1[i] == 2)
                    Two.Add(i + 1);
                else
                    Three.Add(i + 1);
            }
            int team=Math.Min(One.Count,Math.Min(Two.Count,Three.Count));

            Console.WriteLine(team);
            
            for(int j = 0; j < team; j++)
            {
                Console.WriteLine($"{One[j]} {Two[j]} {Three[j]}");
            }
           
        }
    }
}
