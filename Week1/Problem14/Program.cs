using System;
using System.Collections.Generic;
/// <summary>
/// 1207A - There Are Two Types Of Burgers
/// </summary>

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {

            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int[] input1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int[] input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);



                int b = input1[0];
                int p = input1[1];
                int f = input1[2];

                int hp = input2[0];
                int cp = input2[1];

                int hamNumber = 0;
                int burgerNumber = 0;

                List<int> Result = new List<int>();

                if (cp > hp)
                {
                    burgerNumber = Math.Min(b / 2, f);
                    b -= 2 * burgerNumber;
                    hamNumber = Math.Min(b / 2, p);
                }
                else
                {
                    hamNumber = Math.Min(b / 2, p);
                    b -= 2 * hamNumber;
                    burgerNumber = Math.Min(b / 2, f);
                }
                Result.Add(hamNumber * hp + burgerNumber * cp);
                foreach (int item in Result)
                    Console.WriteLine(item);
            }
        }
    }
}
