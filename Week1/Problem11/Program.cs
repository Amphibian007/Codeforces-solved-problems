using System;
using System.Linq;
/// <summary>
/// 1183A	Nearest Interesting Number
/// </summary>

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            int result;

            input = int.Parse(Console.ReadLine());
        recheck:
            {
                 
                 result = input.ToString().Sum(c => c - '0');
                
            }
            if (result % 4 != 0)
            {
                input++;
                goto recheck;
            }
            Console.WriteLine(input);
        }
    }
}
