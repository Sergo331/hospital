using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int humanInTyrn;
            int timeOfReceipt = 10;
            int waitingTimeChas;
            int waitingTimeMin;

            

            Console.Write("Для того, что бы расчитать время ожидания в очереди, введите колличество человек перед вами: ");
            humanInTyrn = Convert.ToInt32(Console.ReadLine());

            waitingTimeChas = (humanInTyrn * timeOfReceipt) / 60;
            waitingTimeMin = (humanInTyrn * timeOfReceipt) % 60;

            Console.WriteLine("Вы должны отстоять в очереди: " +waitingTimeChas + " часа" + waitingTimeMin + " минут.");




        }
    }
}
