using System;

Console.WriteLine("Таблиця множення 10×10:\n");

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i * j,4}");
    }
    Console.WriteLine();
}

Console.Write("\nВведiть N: ");
int N = int.Parse(Console.ReadLine()!);

int sum = 0;

for (int i = 1; i <= N; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
        sum += i;
}

Console.WriteLine($"Сума = {sum}");

Console.Write("\nВведiть номер числа Фiбоначчi N: ");
int fibN = int.Parse(Console.ReadLine()!);

int f1 = 0, f2 = 1, fib = 0;

for (int i = 2; i <= fibN; i++)
{
    fib = f1 + f2;
    f1 = f2;
    f2 = fib;
}

Console.WriteLine($"F({fibN}) = {(fibN == 0 ? 0 : fibN == 1 ? 1 : fib)}");

double bine = (Math.Pow((1 + Math.Sqrt(5)) / 2, fibN) -
               Math.Pow((1 - Math.Sqrt(5)) / 2, fibN)) / Math.Sqrt(5);

Console.WriteLine($"За формулою Бiне = {Math.Round(bine)}");

Console.Write("\nВведiть перше число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введiть друге число: ");
int num2 = int.Parse(Console.ReadLine()!);

while (num2 != 0)
{
    int temp = num2;
    num2 = num1 % num2;
    num1 = temp;
}

Console.WriteLine($"НСД = {num1}");