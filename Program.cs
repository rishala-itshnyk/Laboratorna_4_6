using System;

class Program
{
    static void Main()
    {
        double P, S;
        int i, k;
        P = 1;
        i = 1;

        while (i <= 10)
        {
            S = 0;
            k = 1;

            while (k <= i)
            {
                S += 1.0 / k;
                k++;
            }

            P *= (i + S) / (Math.Sqrt(S));
            i++;
        }

        Console.WriteLine("Спосіб 1: " + P);

        P = 1;
        i = 1;
        do
        {
            S = 0;
            k = 1;
            do
            {
                S += 1.0 / k;
                k++;
            } while (k <= i);
            P *= (i + S) / (Math.Sqrt(S));
            i++;
        } while (i <= 10);
        
        Console.WriteLine("Спосіб 2: " + P);

        P = 1;
        for (i = 1; i <= 10; i++)
        {
            S = 0;

            for (k = 1; k <= i; k++)
            {
                S += 1.0 / k;
            }

            P *= (i + S) / (Math.Sqrt(S));
        }

        Console.WriteLine("Спосіб 3: " + P);

        P = 1;
        for (i = 10; i >= 1; i--)
        {
            S = 0;

            for (k = i; k >= 1; k--)
            {
                S += 1.0 / k;
            }

            P *= (i + S) / (Math.Sqrt(S));
        }

        Console.WriteLine("Спосіб 4: " + P);
    }
}