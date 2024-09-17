using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab1
{
    internal class Program
    {
        static List<string> textFile = new List<string>();
        static List<string> evenWords = new List<string>();
        static List<string> oddWords = new List<string>();
        static List<string> words = new List<string>();


        static void writeInfo()
        {
            Console.WriteLine("\nСлов с четным количеством букв в строке: " + evenWords.Count());
            Console.Write("Слова с четным количеством букв: ");
            for (int i = 0; i < evenWords.Count(); i++)
                Console.Write(evenWords[i] + " (" + evenWords[i].Length + "); ");

            Console.WriteLine("\nСлов с нечетным количеством букв в строке: " + oddWords.Count());
            Console.Write("Слова с нечетным количеством букв: ");
            for (int i = 0; i < oddWords.Count(); i++)
                Console.Write(oddWords[i] + " (" + oddWords[i].Length + "); ");

            oddWords.Clear();
            evenWords.Clear();
        }

        static void solve()
        {
            string[] tmp = { };
            for (int i = 0; i < textFile.Count(); i++)
            {
                tmp = textFile[i].Split(' ', '.', ',', ':', ';', '!', '?', '\r', '\n');
                for (int j = 0; j < tmp.Count(); j++)
                    words.Add(tmp[j]);
                sortWords();
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("\nСтрока №" + (i + 1));
                writeInfo();

                words.Clear();
            }
        }

        static void sortWords()
        {
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i].Length % 2 == 0)
                    evenWords.Add(words[i]);
                else
                    oddWords.Add(words[i]); 
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Лабораторная 1, вариант 15.");
                Console.WriteLine("Сортировка слов по их размеру (четности).");

                FileStream file = new FileStream("C:\\Users\\Admin\\source\\repos\\lab1\\lab1\\test.txt", FileMode.Open);
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                    textFile.Add(sr.ReadLine());
                
                solve();
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("\nЗавершение сценария.");
                Console.ReadKey();
            }
            catch 
            {
                Console.WriteLine("Обработка исключения: ФАЙЛ НЕ БЫЛ НАЙДЕН!");
                Console.ReadKey();
            }
        }
    }
}
