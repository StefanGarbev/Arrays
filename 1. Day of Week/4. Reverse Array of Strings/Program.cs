using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < word.Length / 2; i++)
            {
                var temp = word[i];
                word[i] = word[word.Length - 1 - i];
                word[word.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", word));
        }
    }
}
