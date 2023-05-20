using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter road boundaries(N): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the maximum distance(K): ");
        int K = int.Parse(Console.ReadLine());

      
        int[] population = new int[N];
         string[] inputPopulation = Console.ReadLine().Split(' ');
        for (int i = 0; i < N; i++)
        {
            population[i] = int.Parse(Console.ReadLine());
        }
        int populationSum = 0;
            for (int i = 0; i < N; i++)
        {
            int customers = 0;
            for (int j = i - K; j <= i + K; j++)
            {
                if (j >= 0 && j < N)
                {
                   populationSum += population[j];
                }
            }
                if (populationSum > maxPopulation)
            {
                    populationSum = maxpopulation;  
            }
        }
        Console.WriteLine(maxpopulation);
    }
}