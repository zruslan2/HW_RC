using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservedCopy.Model
{
    public class Flash : Storage
    {
        public int SpeedUSB { get; set; }
        public double MemoryVol { get; set; }
        public Flash(string name, string model, int speedUsb, double memoryVol) : base(name, model)
        {
            this.SpeedUSB = speedUsb;
            this.MemoryVol = memoryVol;
        }
        public override void CopyInfo()
        {
        start:
            Console.WriteLine("Начать копирование файлов/папок на устройство: (1-да, 2-нет)");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Копирование началось.");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(2000);
                }
                Console.WriteLine("Копирование завершилось.");
            }
            else if (ch == 2)
            {
                Console.WriteLine("Отмена копирования");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Ошибка в выборе.");
                goto start;
            }
        }
        public override void GetFreeMemory()
        {
            Console.WriteLine("На устройстве свободно {0} ", MemoryVol, " памяти ");
        }
        public override void GetInfo()
        {
            Console.WriteLine("Информация об устройстве: ");
            Console.WriteLine("Имя: {0}\nМодель: {1}\nСкорость: {2}\nОбьем памяти: {3}", Name, Model, SpeedUSB, MemoryVol);
        }
        public override double GetMemory()
        {
            return this.MemoryVol;
        }
    }
}
