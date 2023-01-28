using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int priceCrystal = 10;
            int crystalCount;

            Console.WriteLine("Добро пожаловать в магазин кристаллов. Цена 1 кристалла " + priceCrystal + " монет.");
            Console.Write("Сколько у вас монет?:");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристаллов Вам нужно?:");
            crystalCount = Convert.ToInt32(Console.ReadLine()); 

            money -= priceCrystal * crystalCount;

            Console.WriteLine("У вас в сумке: " + crystalCount + " кристаллов и " +money +" монет.");
        }
    }
}
