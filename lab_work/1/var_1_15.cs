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

        static void writeInfo(StreamWriter writer)
        {
            writer.WriteLine("\nСлов с четным количеством букв в строке: " + evenWords.Count());
            writer.Write("Слова с четным количеством букв: ");
            for (int i = 0; i < evenWords.Count(); i++)
                writer.Write(evenWords[i] + " (" + evenWords[i].Length + "); ");

            writer.WriteLine("\nСлов с нечетным количеством букв в строке: " + oddWords.Count());
            writer.Write("Слова с нечетным количеством букв: ");
            for (int i = 0; i < oddWords.Count(); i++)
                writer.Write(oddWords[i] + " (" + oddWords[i].Length + "); ");

            oddWords.Clear();
            evenWords.Clear();
        }

        static void solve(StreamWriter writer)
        {
            string[] tmp = { };
            for (int i = 0; i < textFile.Count(); i++)
            {
                tmp = textFile[i].Split(new char[] { ' ', '.', ',', ':', ';', '!', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp.Length; j++)
                    words.Add(tmp[j]);

                sortWords();

                writer.WriteLine("\n----------------------------");
                writer.WriteLine("\nСтрока №" + (i + 1));
                writeInfo(writer);

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

                string inputFilePath = "C:\\Users\\Admin\\source\\repos\\lab1\\lab1\\tes.txt";
                string resultFilePath = "C:\\Users\\Admin\\source\\repos\\lab1\\lab1\\result.txt";

                using (FileStream file = new FileStream(inputFilePath, FileMode.Open))
                using (StreamReader sr = new StreamReader(file))
                using (StreamWriter writer = new StreamWriter(resultFilePath))
                {
                    while (!sr.EndOfStream)
                        textFile.Add(sr.ReadLine());

                    writer.WriteLine("Лабораторная 1, вариант 15.");
                    writer.WriteLine("Сортировка слов по их размеру (четности).");
                    solve(writer);
                    writer.WriteLine("\n----------------------------");
                    writer.WriteLine("\nЗавершение сценария.");
                }

                Console.WriteLine("\n----------------------------");
                Console.WriteLine("\nЗавершение сценария.");
                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Обработка исключения: ФАЙЛ НЕ БЫЛ НАЙДЕН!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Обработка исключения: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}
