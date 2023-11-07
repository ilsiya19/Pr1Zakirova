using System;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 65, 30, 2, 6, 17, 83, 99, 8, 12, 91 };

        // Сортировка массива
        Array.Sort(array);

        Console.WriteLine("Отсортированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}

