﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите n:");
        int n = int.Parse(Console.ReadLine());

        int counter = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (counter > n)
                    break;
                Console.Write(counter + " ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}


