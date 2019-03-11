using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ReservedCopy.Model;

namespace ReservedCopy
{
    public class Application
    {
        public static void TotalMemory()
        {
            Storage[] storage = new Storage[3];
            storage[0] = new Flash("Флэшка", "3.0", 200, 8);
            storage[1] = new DVD("DVD", "5/1", 400, Model.Type.oneside);
            storage[2] = new HDD("HDD", "6/4", 800, 10, 300, 15);
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += storage[i].GetMemory();
            }
            Console.WriteLine("Общее количество памяти всех устройств = {0}", sum);
        }
        public static void StartCopy()
        {
            Storage[] storage = new Storage[3];
            storage[0] = new Flash("Флэшка", "3.0", 200, 8);
            storage[1] = new DVD("DVD", "5/1", 400, Model.Type.oneside);
            storage[2] = new HDD("HDD", "6/4", 800, 10, 300, 15);
        again:
            Console.WriteLine("Выберите для какого устройства начать копирование: (1-Флэшка, 2-DVD, 3-HDD)");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        storage[0].CopyInfo();
                    }
                    break;
                case 2:
                    {
                        storage[1].CopyInfo();
                    }
                    break;
                case 3:
                    {
                        storage[2].CopyInfo();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Неверно выбрано устройство.");
                        goto again;
                    }
                    break;
            }
        }
        public static void TimeCount()
        {
            Storage[] storage = new Storage[3];
            storage[0] = new Flash("Флэшка", "3.0", 200, 8);
            storage[1] = new DVD("DVD", "5/1", 400, Model.Type.oneside);
            storage[2] = new HDD("HDD", "6/4", 800, 10, 300, 15);
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1; i++)
            {
                storage[i].CopyInfo();
                Console.WriteLine("Итого времени на копирование по всем устройствам: {0} секунд", sw.ElapsedMilliseconds / 1000);
            }
            sw.Stop();
        }
        public static void StorageChoice()
        {
            Console.WriteLine("Введите обьем информации для копирования: ");
            int vol = int.Parse(Console.ReadLine());
            if (vol > 1 || vol < 10)
            {
                Console.WriteLine("Используйте флэшку");
            }
            else if (vol > 10 || vol < 20)
            {
                Console.WriteLine("Используйте DVD");
            }
            else if (vol > 20 || vol < 30)
            {
                Console.WriteLine("Используйте HDD");
            }
            else
            {
                Console.WriteLine("Купите новый комп:)");
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Добро пожаловать!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Выберите необходимые действия: ");
            Console.WriteLine("1. Расчет общего количества памяти на всех устройствах\n2. Копирование информации на устройство\n3. Расчет времени необходимого для копирования\n4. Выбор носителя\n5. Выход");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TotalMemory();
                    break;
                case 2:
                    StartCopy();
                    break;
                case 3:
                    TimeCount();
                    break;
                case 4:
                    StorageChoice();
                    break;
                case 5:
                    Console.WriteLine("До свидания!");
                    Thread.Sleep(1000);
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
}
