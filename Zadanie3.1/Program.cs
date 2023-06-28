using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj liczbę wierszy i kolumn:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int a = n;
        int[,] tablica = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    tablica[i, j] = i * n + j + 1;
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    tablica[i, j] = i * n + (n - 1 - j) + 1;
                }
            }
        }

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}