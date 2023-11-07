using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N:");
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(currentNumber + " ");
                currentNumber++;
            }
            Console.WriteLine();
        }
    }
}


