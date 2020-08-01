using System;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int books = 0;
            int[] input=Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int[] input2=Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            
            int a = input[0];
            int b = input[1];
            Array.Sort(input2);
           
            for( i = 0; i < a; i++)
            {
                books += input2[i];
                if (books == b)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
                else if (books > b)
                {
                    Console.WriteLine(i);
                    break;
                }
              
            }
            if(books<b)
                Console.WriteLine(a);
           
           

        }
    }
}
