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
            int humanInQueue;
            int timeOfReceipt = 10;
            int waitingTimeHour;
            int waitingTimeMinutes;
            int minutesInHour = 60;

            Console.Write("Для того, что бы расчитать время ожидания в очереди, введите колличество человек перед вами: ");
            humanInQueue = Convert.ToInt32(Console.ReadLine());

            waitingTimeHour = (humanInQueue * timeOfReceipt) / minutesInHour;
            waitingTimeMinutes = (humanInQueue * timeOfReceipt) % minutesInHour;

            Console.WriteLine("Вы должны отстоять в очереди: " +waitingTimeHour + " часа " + waitingTimeMinutes+ " минут.");

        }
    }
}
