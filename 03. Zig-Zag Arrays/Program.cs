using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ArrEven = new int[n];
            int[] ArrOdd = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] consoleNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int EvenNumbers = consoleNumbers[0];
                int OddNumbers = consoleNumbers[1]; 

                if (i % 2 == 0)
                {
                    ArrEven[i] = EvenNumbers;
                    ArrOdd[i] = OddNumbers;
                }
                else
                {
                    ArrEven[i] = OddNumbers;
                    ArrOdd[i] = EvenNumbers;  
                }
            }
            Console.WriteLine(string.Join(" ",ArrEven));
            Console.WriteLine(string.Join(" ",ArrOdd));
        }
    }
}
