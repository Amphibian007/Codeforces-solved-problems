using System;

namespace D2Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(isMagical(input))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            
        }
        public static bool isMagical(string number)
        {
            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] != '1' && number[i] != '4')
                    return false;
            }
            if (number[0] == '4')
                return false;
            if (number.Contains("444"))
                return false;

            return true;
     
        }
    }
}
