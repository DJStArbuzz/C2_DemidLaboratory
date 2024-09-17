using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace laba2
{
    class Class1
    {

        static List<string> slova = new List<string>();


        static void one()
        {
            for (int i = 0; i < slova.Count(); i++)
            {
                string[] name = slova[i].Split(' ', '.', ',', ':', ';', '!', '?', '\r', '\n');
                for (int j = 0; j < name.Count(); j++)
                    Console.Write(name[j] + " ");
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            try
            {
                FileStream file = new FileStream("C:\\Users\\d.kulikov\\Desktop1\\ConsoleApplication1\\spisok.txt", FileMode.Open);
               // FileStream file = new FileStream("${Environment.CurrentDirectory}\\spisok.txt", FileMode.Open);
                //FileStream file = new FileStream($"{Environment.CurrentDirectory}\\spisok.txt", FileMode.Open);
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                    slova.Add(sr.ReadLine());
                Console.ReadKey();
                one();
                Console.WriteLine();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine($"Current directory is '{Environment.CurrentDirectory}'");
                Console.WriteLine("Обработка исключения");
                Console.ReadKey();
            }
        }
    }
}


