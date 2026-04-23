using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 7, 45, 64, 23, 88, 31, 40 };

        int even = 0, odd = 0;
        foreach (int n in numbers)
        {
            if (n % 2 == 0) even++;
            else odd++;
        }
        Console.WriteLine($"Парних: {even}, Непарних: {odd}");

        Console.WriteLine("Перший елемент > 50:");
        foreach (int n in numbers)
        {
            if (n > 50)
            {
                Console.WriteLine(n);
                break;
            }
        }

        var words = new List<string> { "київ", "Лубни", "одеса", "Пирятин", "днiпро" };

        Console.WriteLine("Слова з великої лiтери:");
        foreach (string w in words)
        {
            if (!char.IsUpper(w[0])) continue;
            Console.WriteLine(w);
        }

        Console.WriteLine("\nТе саме через for:");

        even = 0; odd = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) even++;
            else odd++;
        }
        Console.WriteLine($"Парних: {even}, Непарних: {odd}");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 50)
            {
                Console.WriteLine(numbers[i]);
                break;
            }
        }

        for (int i = 0; i < words.Count; i++)
        {
            if (!char.IsUpper(words[i][0])) continue;
            Console.WriteLine(words[i]);
        }
    }
}