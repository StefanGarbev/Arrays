using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            int evenNumberSum = 0;
            int oddNumberSum = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 0)
                {
                    evenNumberSum += Numbers[i];
                }
                else
                { 
                    oddNumberSum += Numbers[i];
                }
            }

            //Console.WriteLine($"{evenNumberSum}");
            //Console.WriteLine($"{oddNumberSum}");
            Console.WriteLine($"{evenNumberSum - oddNumberSum}");
        }
    }
}
