using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVagons = int.Parse(Console.ReadLine());
            int sumOfPassengers = 0;
            int[] vagonsPassanger  = new int[numberOfVagons];

            for (int i = 0; i < numberOfVagons; i++)
            {
                vagonsPassanger[i] = int.Parse(Console.ReadLine());
                sumOfPassengers += vagonsPassanger[i];
            }
            for (int i = 0; i < numberOfVagons; i++)
            {
                Console.Write($"{vagonsPassanger[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPassengers);
        }
    }
}
