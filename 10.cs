using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindNthDigit(123456789, 5));
    }

    static int FindNthDigit(int number, int index)
    {
        int count = 0;

        while (number != 0)
        {
            count++;
            if (count == index)
            {
                return number % 10;
            }
            number /= 10;
        }

        return -1; // если индекс не найден
    }
}

