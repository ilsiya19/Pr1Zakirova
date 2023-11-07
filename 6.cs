using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (char k = 'a'; k < 'a' + l; k++)
                {
                    for (char m = 'a'; m < 'a' + l; m++)
                    {
                        string password = $"{i}{j}{k}{m}{i + j}";

                        Console.WriteLine(password);
                    }
                }
            }
        }
    }
}



