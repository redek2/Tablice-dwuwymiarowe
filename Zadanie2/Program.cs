using System;

class Program
{
    static void Main()
    {
        int n = 10;
        int[,] tablica = new int[10, 10];

        int liczba, k, l, m;
        liczba = 1;
        k = 0;
        l = 0;
        m = n;

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