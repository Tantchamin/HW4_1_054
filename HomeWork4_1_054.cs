using System;

namespace HomeWork4_1_054
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            while (row < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                row = int.Parse(Console.ReadLine());
            }
            PascalTriangle(row);
        }
        static void PascalTriangle(int n)
        {
            for (int i = 0; i <= n; i++) // i = nFac
            {
                for (int r = 0; r <= i; r++) // r = rFac
                {
                    int nFactorial = 1;
                    if (i <= 1)
                    {
                        nFactorial = 1;
                    }
                    else
                    {
                        for (int nFac = 1; nFac <= i; nFac++)
                        {
                            nFactorial *= nFac;
                        }
                    }
                    int rFactorial = 1;
                    if (r <= 1)
                    {
                        rFactorial = 1;
                    }
                    else
                    {
                        for (int rFac = 1; rFac <= r; rFac++)
                        {
                            rFactorial *= rFac;
                        }
                    }
                    int n_rFactorial = 1;
                    if ((i - r) <= 1)
                    {
                        n_rFactorial = 1;
                    }
                    else
                    {
                        for (int n_rFac = 1; n_rFac <= i - r; n_rFac++)
                        {
                            n_rFactorial *= n_rFac;
                        }
                    }
                    int Pascal = nFactorial / (rFactorial * n_rFactorial);
                    Console.Write(Pascal + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
