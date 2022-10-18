using System;   
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numCounter = 0;
            int topCounter = 0;
            int index = 0;
            string value = string.Empty;

            for (int i = 0; i < inputArray.Length-1; i++)
            {
               
                if (inputArray[i] == inputArray[i+1])
                {
                    numCounter++;
                    if (topCounter < numCounter)
                    {
                        topCounter = numCounter;
                        index = i;
                        value = inputArray[i].ToString();
                    }
                }
                else
                {
                    numCounter = 0;
                }
            }
            for (int i = 0; i <= topCounter; i++)
            {
                Console.Write(value + " ");
            }
        }
    }
}
