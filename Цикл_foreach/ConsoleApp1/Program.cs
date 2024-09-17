using System;
using System.IO;

class ReadFromFile
{
    static void Main()
    {
        Console.Write("Введите слова через пробел: ");
        string[] chisla = Console.ReadLine().Split(new char[] { ' ' });
        Console.Write("Вывести все слова, длина которых больше чем ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        foreach (string c in chisla)
        {
            if (c.Length > a)
            {
                Console.WriteLine(c + " " + c.Length + " символов");
            }
        }
        Console.ReadKey();
    }
}

