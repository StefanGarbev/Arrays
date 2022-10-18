using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumOfElementsRight = 0;
            int sumOfElementsLeft = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentNumber = inputArray[i];
                sumOfElementsRight = 0;
                sumOfElementsLeft = 0;

                for (int K = i + 1; K < inputArray.Length; K++)
                {
                    int nextNumber = inputArray[K];
                    sumOfElementsRight += nextNumber;
                }
                for (int j = 0; j < i ; j++)
                {
                    int beforeNumber = inputArray[j];
                    sumOfElementsLeft+=beforeNumber;
                }

                if (sumOfElementsLeft == sumOfElementsRight)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (sumOfElementsRight != sumOfElementsLeft)
            {
                Console.WriteLine("no");
            }
        }
    }
}
