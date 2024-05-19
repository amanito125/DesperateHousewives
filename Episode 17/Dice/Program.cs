using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] results = new int[6];
        int totalThrows = 5000;

        for (int i = 0; i < totalThrows; i++)
        {
            int result = rand.Next(1, 7);
            results[result - 1]++;
        }

        Console.WriteLine("Average chance for each result:");
        for (int i = 0; i < results.Length; i++)
        {
            double averageChance = (double)results[i] / totalThrows * 100;
            Console.WriteLine($"Result {i + 1}: {averageChance}%");
        }
    }
}
