using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"{Array[i]} => {(int)Math.Round(Array[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
