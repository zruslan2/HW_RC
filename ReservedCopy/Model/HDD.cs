using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservedCopy.Model
{
    public class HDD : Storage
    {
        public int SpeedUSB { get; set; }
        public int CountSections { get; set; }
        public int SectionsVol { get; set; }
        public double MemoryVol { get; set; }
        public HDD(string name, string model, int speedUsb, int countSection, int sectionVol, double memoryVol) : base(name, model)
        {
            this.SpeedUSB = speedUsb;
            this.CountSections = countSection;
            this.SectionsVol = sectionVol;
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
            Console.WriteLine("Имя: {0}\nМодель: {1}\nСкорость: {2}\nКоличество разделов: {3}\nОбьем разделов: {4}\nОбьем памяти: {5}", Name, Model, SpeedUSB, CountSections, SectionsVol, MemoryVol);
        }
        public override double GetMemory()
        {
            return this.MemoryVol;
        }
    }
}
