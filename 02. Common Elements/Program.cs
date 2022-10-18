using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int index = 5;
            string[] final = new string [index];
            string dublicate = string.Empty;
            int k = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[j] == array2[i])
                    {
                        dublicate = array1[j]; 
                        final[k] = dublicate; 
                        k++;
                    }
                    else
                    {
                        continue;
                    }
                } 
            }

            Console.WriteLine(String.Join(" ", final));
        }
    }
}
