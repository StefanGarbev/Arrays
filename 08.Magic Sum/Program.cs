using System;
using System.Linq;

namespace _08.Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            int sumOfElements = 0;
            
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    
                    sumOfElements = inputArray[i] + inputArray[j];

                    if (number == sumOfElements)
                    {
                        Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
                    }
                }
            }
        }
    }
}
