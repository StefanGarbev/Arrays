﻿using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] arr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
