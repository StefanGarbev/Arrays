using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] arrayOutput = new int[n];
            for (int j = 0; j < n; j++)
            {
                var temp = arrayInput[0];
                for (int i = 1; i < arrayInput.Length; i++)
                {
                    arrayInput[i - 1] = arrayInput[i];
                }
                arrayInput[arrayInput.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ",arrayInput));
        }
    }
}
