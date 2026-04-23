using System;

int n = 6;

Console.WriteLine("Порожнiй квадрат:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
            Console.Write("* ");
        else
            Console.Write("  ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nШахова дошка:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write((i + j) % 2 == 0 ? "# " : ". ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nЧисловий трикутник:");

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

int m = 10;

Console.WriteLine("\nРамка:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == 0 && j == 0) Console.Write("╔");
        else if (i == 0 && j == m - 1) Console.Write("╗");
        else if (i == n - 1 && j == 0) Console.Write("╚");
        else if (i == n - 1 && j == m - 1) Console.Write("╝");
        else if (i == 0 || i == n - 1) Console.Write("═");
        else if (j == 0 || j == m - 1) Console.Write("║");
        else Console.Write(" ");
    }
    Console.WriteLine();
}