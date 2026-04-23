using System;

int? bestScore = null;
bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   ДЕМОНСТРАЦiЯ ЦИКЛiВ ТА УМОВ        ║");
    Console.WriteLine("╠══════════════════════════════════════╣");
    Console.WriteLine("║  1. Таблиця множення                 ║");
    Console.WriteLine("║  2. Числа Фiбоначчi                  ║");
    Console.WriteLine("║  3. Фiгури iз зiрочок                ║");
    Console.WriteLine("║  4. Простi числа до N                ║");
    Console.WriteLine("║  5. Вгадай число (гра)               ║");
    Console.WriteLine("║  0. Вихiд                            ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.Write("  Оберiть пункт: ");

    running = Console.ReadLine() switch
    {
        "1" => ShowMultiplicationTable(),
        "2" => ShowFibonacci(),
        "3" => ShowStars(),
        "4" => ShowPrimes(),
        "5" => PlayGuessGame(ref bestScore),
        "0" => false,
        _ => ShowError()
    };
}

static bool ShowMultiplicationTable()
{
    Console.Clear();

    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
            Console.Write($"{i * j,4}");

        Console.WriteLine();
    }

    Console.ReadKey();
    return true;
}

static bool ShowFibonacci()
{
    Console.Clear();

    int a = 0, b = 1;

    Console.WriteLine("Числа Фiбоначчi:");

    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{a} ");
        int temp = a + b;
        a = b;
        b = temp;
    }

    Console.ReadKey();
    return true;
}

static bool ShowStars()
{
    Console.Clear();

    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < i; j++)
            Console.Write("* ");

        Console.WriteLine();
    }

    Console.ReadKey();
    return true;
}

static bool ShowPrimes()
{
    Console.Clear();

    Console.WriteLine("Простi числа вiд 1 до 100:");

    int count = 0;

    for (int i = 2; i <= 100; i++)
    {
        if (IsPrime(i))
        {
            Console.Write($"{i,4}");

            if (++count % 10 == 0)
                Console.WriteLine();
        }
    }

    Console.WriteLine($"\nВсього простих: {count}");

    Console.Write("\nВведiть число: ");
    int num = int.Parse(Console.ReadLine()!);

    int candidate = num > 2 ? num : 2;

    while (!IsPrime(candidate))
        candidate++;

    Console.WriteLine($"Найближче просте >= {num}: {candidate}");

    Console.ReadKey();
    return true;
}

static bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    for (int i = 3; i * i <= n; i += 2)
        if (n % i == 0)
            return false;

    return true;
}

static bool PlayGuessGame(ref int? bestScore)
{
    Console.Clear();

    Random rnd = new Random();
    int secret = rnd.Next(1, 101);

    int attempts = 0;
    int min = 1;
    int max = 100;

    Console.WriteLine("Вгадайте число вiд 1 до 100!");
    Console.WriteLine("Режим HARD активовано.");

    while (true)
    {
        Console.WriteLine($"Дiапазон: [{min} ; {max}]");
        Console.Write($"Спроба {attempts + 1}: ");

        if (!int.TryParse(Console.ReadLine(), out int guess))
        {
            Console.WriteLine("Введiть цiле число!");
            continue;
        }

        attempts++;

        if (guess < secret)
        {
            Console.WriteLine("Бiльше!");
            min = guess + 1;
        }
        else if (guess > secret)
        {
            Console.WriteLine("Менше!");
            max = guess - 1;
        }
        else
        {
            Console.WriteLine($"Вiрно! Спроб: {attempts}");

            if (bestScore == null || attempts < bestScore)
            {
                bestScore = attempts;
                Console.WriteLine("Новий рекорд!");
            }

            Console.WriteLine($"Рекорд: {bestScore}");
            Console.ReadKey();
            return true;
        }
    }
}

static bool ShowError()
{
    Console.WriteLine("Невiрний пункт меню!");
    Console.ReadKey();
    return true;
}