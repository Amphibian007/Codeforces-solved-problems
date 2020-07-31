using System;
/// <summary>
/// Codeforces Round #320 (Div. 2) [Bayan Thanks-Round], problem: (A) Raising Bacteria
/// </summary>

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
