using System;

bool repeat;

do
{
    int n;

    do
    {
        Console.Write("Введiть кiлькiсть чисел (2-50): ");
    }
    while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 50);

    int[] numbers = new int[n];

    for (int i = 0; i < n; i++)
    {
        do
        {
            Console.Write($"Введiть число {i + 1}: ");
        }
        while (!int.TryParse(Console.ReadLine(), out numbers[i]));
    }

    int[] sorted = new int[n];
    Array.Copy(numbers, sorted, n);

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (sorted[j] > sorted[j + 1])
            {
                int temp = sorted[j];
                sorted[j] = sorted[j + 1];
                sorted[j + 1] = temp;
            }
        }
    }

    int min = sorted[0];
    int max = sorted[n - 1];
    int sum = 0;

    int even = 0;
    int odd = 0;
    int negative = 0;
    int prime = 0;

    foreach (int num in numbers)
    {
        sum += num;

        if (num % 2 == 0) even++;
        else odd++;

        if (num < 0) negative++;

        if (IsPrime(num)) prime++;
    }

    double average = (double)sum / n;

    double median;
    if (n % 2 == 0)
        median = (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
    else
        median = sorted[n / 2];

    Console.WriteLine("\n--- АНАЛiЗ ---");
    Console.WriteLine($"Мiнiмум: {min}");
    Console.WriteLine($"Максимум: {max}");
    Console.WriteLine($"Сума: {sum}");
    Console.WriteLine($"Середнє: {average}");
    Console.WriteLine($"Медiана: {median}");

    Console.WriteLine($"\nПростих: {prime}");
    Console.WriteLine($"Парних: {even}");
    Console.WriteLine($"Непарних: {odd}");
    Console.WriteLine($"Вiд'ємних: {negative}");

    Console.WriteLine("\nВiдсортований масив:");
    foreach (int num in sorted)
        Console.Write($"{num} ");

    Console.WriteLine("\n\nГiстограма:");
    foreach (int num in numbers)
    {
        Console.Write($"{num,4}: ");
        for (int i = 0; i < Math.Abs(num); i++)
            Console.Write("█");
        Console.WriteLine();
    }

    string choice;
    do
    {
        Console.Write("\n1 - Новий масив, 0 - Вихiд: ");
        choice = Console.ReadLine()!;
    }
    while (choice != "1" && choice != "0");

    repeat = choice == "1";

} while (repeat);

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