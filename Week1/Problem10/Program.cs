using System;
/// <summary>
/// 1303A	Erasing Zeroes
/// </summary>

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int count = 0;
                string input = Console.ReadLine();
                int m = input.IndexOf('1');

                int n = input.LastIndexOf('1');

                for (int j = m; j < n; j++)
                {
                    if (input[j] == '0')
                        count++;

                }
                Console.WriteLine(count);
            }
        }
    }
}
