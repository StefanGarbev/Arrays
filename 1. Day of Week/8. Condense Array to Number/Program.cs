using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] condensedArray = new int[ArrayNumber.Length-1];

            if (ArrayNumber.Length == 1)
            {
                Console.WriteLine(ArrayNumber[0]);
                return;
            }
            else 
            {
                for (int i = 0; i < ArrayNumber.Length; i++)
                {
                    for (int j = 0; j < condensedArray.Length - i; j++)
                    {
                        condensedArray[j] = ArrayNumber[j] + ArrayNumber[j + 1];
                    }
                    ArrayNumber = condensedArray;
                }
                Console.WriteLine(condensedArray[0]);
            } 
        }
    }
}
