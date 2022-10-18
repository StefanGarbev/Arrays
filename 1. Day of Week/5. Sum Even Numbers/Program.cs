using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int evenNumberSum = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 0)
                { 
                    evenNumberSum += Numbers[i];
                }
            }

            Console.WriteLine(evenNumberSum);
        }
    }
}
