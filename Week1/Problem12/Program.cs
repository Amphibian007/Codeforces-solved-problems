using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int start = input[0];
            int end = input[1];
            int n = end /start;
            
                int count = 0;

                while (n % 2 == 0)
                {
                    count++;
                    n /= 2;
                }
                while (n % 3 == 0)
                {
                    count++;
                    n /= 3;
                }
               
               if(n==1&&end%start==0)
                Console.WriteLine(count);
               else
                Console.WriteLine(-1);
            Console.WriteLine(5%1);
        }
    }
}
