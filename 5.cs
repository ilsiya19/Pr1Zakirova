using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите день:");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите месяц:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите год:");
        int year = int.Parse(Console.ReadLine());

        bool dateIsCorrect = CheckDate(day, month, year);

        if (dateIsCorrect)
            Console.WriteLine("the date is correct");
        else
            Console.WriteLine("the date is incorrect");
    }

    static bool CheckDate(int day, int month, int year)
    {
        // Проверка года на корректность
        if (year < 1)
            return false;

        // Проверка месяца на корректность
        if (month < 1 || month > 12)
            return false;

        // Проверка дня на корректность, в зависимости от месяца
        if (day < 1 || day > GetDaysInMonth(month, year))
            return false;

        return true;
    }

    static int GetDaysInMonth(int month, int year)
    {
        // Проверка на февраль (всегда 28 дней)
        if (month == 2)
            return 28;

        // Проверка на месяцы с 30 днями
        if (month == 4 || month == 6 || month == 9 || month == 11)
            return 30;

        // По умолчанию месяцы с 31 днем
        return 31;
    }
}


