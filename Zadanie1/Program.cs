using System;

public class Program
{
    public static void Main()
    {
        int n = 10;
        int[,] tablica = new int[10, 10];

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

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}