using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSequence = int.Parse(Console.ReadLine());
            string sequance = Console.ReadLine();
            int DNAcounter = 0;
            int[] bestSample = new int[lenghtOfSequence];
            int leftmostIndex = lenghtOfSequence;
            int bestSampleSequenseLenght = 0;
            int bestSampleSum = 0;
            int bestSampleNumber = 1;

            while (sequance != "Clone them!")
            {
                int[] inputArray = sequance
                   .Split("!")
                   .Select(int.Parse)
                   .ToArray();

                DNAcounter++;

                int currentSequenceLenght = 0;
                int previousSequenceLenght = 0;
                int currentLongestSequence = 0;

                int leftmostIndexInCurrentArray = lenghtOfSequence;

                int currentSampleSum = 0;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] == 1)
                    {
                        currentSequenceLenght++;
                        currentSampleSum++;
                    }
                    else
                    {
                        previousSequenceLenght = currentSequenceLenght;
                        currentSequenceLenght = 0;
                    }

                    if (currentSequenceLenght > previousSequenceLenght)
                    {
                        currentLongestSequence = currentSequenceLenght;
                        leftmostIndexInCurrentArray = i - currentSequenceLenght + 1;
                    }
                }

                if (currentLongestSequence > bestSampleSequenseLenght)
                {
                    bestSampleSequenseLenght = currentLongestSequence;
                    leftmostIndex = leftmostIndexInCurrentArray;
                    bestSample = inputArray;
                    bestSampleNumber = DNAcounter;
                    bestSampleSum = currentSampleSum;
                }
                else if (currentLongestSequence == bestSampleSequenseLenght)
                {
                    if (leftmostIndexInCurrentArray < leftmostIndex)
                    {
                        leftmostIndex = leftmostIndexInCurrentArray;
                        bestSampleSum = currentSampleSum;
                        bestSample = inputArray;
                        bestSampleNumber = DNAcounter;
                    }
                    else if (leftmostIndex == leftmostIndexInCurrentArray)
                    {
                        if (currentSampleSum > bestSampleSum)
                        {
                            bestSampleSum = currentSampleSum;
                            bestSample = inputArray;
                            bestSampleNumber = DNAcounter;
                        }
                    }
                }

                sequance = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSampleSum}.");
            Console.WriteLine(string.Join(" ", bestSample));
        
        }
    }
}
