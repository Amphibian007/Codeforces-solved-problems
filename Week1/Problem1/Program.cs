using System;

namespace Problem1
{
    /// <summary>
    /// This is Balanced Array problem-- 1343 A
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 4 == 0)
                {
                    Console.WriteLine("YES");
                    for (int m = 2; m <= input; m += 2)

                        Console.Write(m + " ");



                    for (int n = 1; n < input; n += 2)
                    {
                        if (n == input - 1)
                        {
                            Console.WriteLine(n + (input / 2));
                            break;
                        }
                        Console.Write(n + " ");
                    }
                }
                else
                
                    Console.WriteLine("NO");
                
            }
        }
    }
}
    

