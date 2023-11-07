using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите тип показа (премьера, обычный или льготный):");
        string showType = Console.ReadLine();

        Console.WriteLine("Введите количество строк в зале:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в зале:");
        int columns = int.Parse(Console.ReadLine());

        int totalIncome = CalculateTotalIncome(showType, rows, columns);
        Console.WriteLine("Общий доход от билетов: " + totalIncome + " рублей");
    }

    static int CalculateTotalIncome(string showType, int rows, int columns)
    {
        int ticketPrice = 0;

        if (showType == "премьера")
        {
            ticketPrice = 600;
        }
        else if (showType == "обычный")
        {
            ticketPrice = 410;
        }
        else if (showType == "льготный")
        {
            ticketPrice = 250;
        }
        else
        {
            Console.WriteLine("Неверный тип показа.");
            return 0;
        }

        int totalSeats = rows * columns;
        int totalIncome = ticketPrice * totalSeats;

        return totalIncome;
    }
}

