using System;

class Program
{
    static void Main()
    {
        // --- 1. Пора року ---
        Console.Write("Введiть номер мiсяця (1–12): ");
        int month = int.Parse(Console.ReadLine()!);

        string season = month switch
        {
            12 or 1 or 2 => "Зима",
            3 or 4 or 5 => "Весна",
            6 or 7 or 8 => "Лiто",
            9 or 10 or 11 => "Осiнь",
            _ => "Невiдомо"
        };

        Console.WriteLine($"Пора року: {season}");

        // --- 2. Знак зодiаку ---
        Console.Write("Введiть день народження: ");
        int dayB = int.Parse(Console.ReadLine()!);

        Console.Write("Введiть мiсяць народження: ");
        int monthB = int.Parse(Console.ReadLine()!);

        string zodiac;

        if ((monthB == 3 && dayB >= 21) || (monthB == 4 && dayB <= 19))
            zodiac = "Овен";
        else if ((monthB == 4 && dayB >= 20) || (monthB == 5 && dayB <= 20))
            zodiac = "Телець";
        else if ((monthB == 5 && dayB >= 21) || (monthB == 6 && dayB <= 20))
            zodiac = "Близнюки";
        else if ((monthB == 6 && dayB >= 21) || (monthB == 7 && dayB <= 22))
            zodiac = "Рак";
        else if ((monthB == 7 && dayB >= 23) || (monthB == 8 && dayB <= 22))
            zodiac = "Лев";
        else if ((monthB == 8 && dayB >= 23) || (monthB == 9 && dayB <= 22))
            zodiac = "Дiва";
        else if ((monthB == 9 && dayB >= 23) || (monthB == 10 && dayB <= 22))
            zodiac = "Терези";
        else if ((monthB == 10 && dayB >= 23) || (monthB == 11 && dayB <= 21))
            zodiac = "Скорпiон";
        else if ((monthB == 11 && dayB >= 22) || (monthB == 12 && dayB <= 21))
            zodiac = "Стрiлець";
        else if ((monthB == 12 && dayB >= 22) || (monthB == 1 && dayB <= 19))
            zodiac = "Козерiг";
        else if ((monthB == 1 && dayB >= 20) || (monthB == 2 && dayB <= 18))
            zodiac = "Водолiй";
        else if ((monthB == 2 && dayB >= 19) || (monthB == 3 && dayB <= 20))
            zodiac = "Риби";
        else
            zodiac = "Невiдомо";

        Console.WriteLine($"Ваш знак зодiаку: {zodiac}");

        // --- 3. Конвертер оцiнки ---
        Console.Write("Введiть оцiнку (A/B/C/D/F): ");
        string gradeLetter = Console.ReadLine()!.ToUpper();

        int numeric = gradeLetter switch
        {
            "A" => 90,
            "B" => 80,
            "C" => 70,
            "D" => 60,
            "F" => 50,
            _ => 0
        };

        Console.WriteLine($"Числовий еквiвалент: {numeric}");
    }
}