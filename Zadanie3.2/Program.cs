using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wierszy i kolumn:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[,] tablica = new int[n, n];

        int liczba, k, l, m, a;
        liczba = 1;
        k = 0;
        l = 0;
        m = n;
        a = n;

        while (k < n && l < n)
        {
            for (int i = k; i < m; i++)
            {
                tablica[l, i] = liczba;
                liczba++;
            }

            l++;
            for (int i = l; i < m; i++)
            {
                tablica[i, n - 1] = liczba;
                liczba++;
            }
            n--;
            if (l < m)
            {
                for (int i = n - 1; i >= k; i--)
                {
                    tablica[m - 1, i] = liczba;
                    liczba++;
                }
                m--;
            }
            if (k < n)
            {
                for (int i = m - 1; i >= l; i--)
                {
                    tablica[i, k] = liczba;
                    liczba++;
                }
                k++;
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