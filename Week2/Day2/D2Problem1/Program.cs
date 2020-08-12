using System;
/// <summary>
/// 255A - Greg's Workout
/// </summary>

namespace D2Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chest=0;
            int biceps = 0;
            int back = 0;
            int n = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int i = 0; i < n; i += 3)
                chest += input[i];
            for (int i = 1; i < n; i += 3)
                biceps += input[i];
            for (int i = 2; i < n; i += 3)
                back += input[i];
            if(chest>biceps&&chest>back)
                Console.WriteLine("chest");
            else if(biceps>chest&&biceps>back)
                Console.WriteLine("biceps");
            else
                Console.WriteLine("back");


        }
    }
}
