using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class TVSet
    {
        private bool switchedOn;
        private int channel;
        private readonly Dictionary<int, string> channels = new Dictionary<int, string>()
        {
            { 1, "Первый канал" },
            { 2, "Россия 1" },
            { 3, "Матч ТВ" },
            { 4, "НТВ" },
            { 5, "5 Канал" },
            { 6, "Россия К" },
            { 7, "Россия 24" },
            { 8, "Карусель" },
            { 9, "ОТР" },
            { 10, "ТВЦ" },
            { 11, "РЕН ТВ" },
            { 12, " Спас" },
            { 13, "СТС" },
            { 14, "Домашний" },
            { 15, "ТВ 3" },
            { 16, "Пятница" },
            { 17, "Звезда" },
            { 18, "МИР" },
            { 19, "ТНТ (Ятс)" },
            { 20, "МУЗ ТВ" },
            { 21, "Shopping Life" },
            { 22, "Первый ярославский" },
            { 23, "Че" }
        };

        public TVSet()
        {
            channel = channels.Keys.First();
        }

        public void SwitchOn()
        {
            switchedOn = true;
            Console.WriteLine("Телевизор включен, текущий канал {0}", channels[channel]);
        }

        public void SwitchOff()
        {
            switchedOn = false;
            Console.WriteLine("Телевизор выключен");
        }

        public void ExitChannel()
        {
            
            Environment.Exit(0);
        }
        public void NextChannel()
        {
            // если ТВ выключен, то ничего не делаем
            if (!switchedOn) return;

            channel++;
            if (!channels.ContainsKey(channel))
                channel = channels.Keys.First();

            Console.WriteLine("Следующий канал {0}", channels[channel]);
        }

        public void PreviousChannel()
        {
            // если ТВ выключен, то ничего не делаем
            if (!switchedOn) return;
            if (channel == 0)
                throw new ApplicationException("Не существует предыдущего канала.");

            channel--;
            if (!channels.ContainsKey(channel))
                channel = channels.Keys.First();

            Console.WriteLine("Следующий канал {0}", channels[channel]);
        }

        public void SetChannel(int newChannel)
        {
            // если ТВ выключен, то ничего не делаем
            if (!switchedOn) return;

            if (!channels.ContainsKey(newChannel))
                throw new ApplicationException("Запрашиваемый канал не существет.");

            channel = newChannel;
            Console.WriteLine("Включен канал {0}", channels[channel]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TVSet myTV = new TVSet();

            Console.WriteLine("Введите команду:");
            Console.WriteLine("on - включить, off - выключить, + - следующий канал, - - предыдущий канал, число - включить канал, q - выход");
            while (true)
            {
                try
                {
                    var command = Console.ReadLine();
                    if ("on".Equals(command, StringComparison.InvariantCultureIgnoreCase))
                    {
                        myTV.SwitchOn();
                    }
                    else if ("off".Equals(command, StringComparison.InvariantCultureIgnoreCase))
                    {
                        myTV.SwitchOff();
                    }
                    else if ("+".Equals(command, StringComparison.InvariantCultureIgnoreCase))
                    {
                        myTV.NextChannel();
                    }
                    else if ("-".Equals(command, StringComparison.InvariantCultureIgnoreCase))
                    {
                        myTV.PreviousChannel();
                    }
                    else if ("q".Equals(command, StringComparison.InvariantCultureIgnoreCase))
                    {
                        myTV.ExitChannel();
                    }
                    else
                    {
                        int newChannel = 0;
                        if (int.TryParse(command, out newChannel))
                            myTV.SetChannel(newChannel);
                        else
                            Console.WriteLine("Команда не распознана");
                    }
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}