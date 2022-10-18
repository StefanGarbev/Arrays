using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] Array2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int diffcounter = 0;
            int sumOfIndex = 0;
            for (int i = 0; i < Math.Min(Array1.Length,Array2.Length); i++)
            {
                if (Array1[i] != Array2[i])
                {
                    diffcounter++;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else if (Array1[i] == Array2[i])
                {
                    sumOfIndex += Array1[i];
                }
            }

            if (sumOfIndex > 0 && diffcounter == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfIndex}");
            }
            
        }
    }
}
