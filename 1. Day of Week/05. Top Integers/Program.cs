using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
           
            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentNumber = inputArray[i];

                bool topInteger = true;

                for (int K = i+1; K < inputArray.Length ; K++)
                {
                    int nextNumber = inputArray[K];

                    if (nextNumber >= currentNumber)
                    { 
                        topInteger = false;
                        break;
                    }
                }
                if (topInteger)
                {
                    Console.Write(currentNumber + " ");  
                }
                
            }
        }
    }
}
